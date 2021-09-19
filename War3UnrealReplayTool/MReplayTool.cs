using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace War3UnrealReplayTool
{
    public partial class MainReplayForm : Form
    {
        public MainReplayForm ( )
        {
            InitializeComponent( );
        }

        List<byte> inputw3gdata;

        public void CopyStream ( System.IO.Stream input , System.IO.Stream output )
        {
            byte [ ] buffer = new byte [ 2000 ];
            int len;
            while ( ( len = input.Read( buffer , 0 , 2000 ) ) > 0 )
            {
                output.Write( buffer , 0 , len );
            }
            output.Flush( );
        }

        byte [ ] DecompressData ( byte [ ] inData )
        {
            using ( MemoryStream outMemoryStream = new MemoryStream( ) )
            using ( zlib.ZOutputStream outZStream = new zlib.ZOutputStream( outMemoryStream,zlib.zlibConst.Z_BEST_COMPRESSION ) )
            using ( Stream inMemoryStream = new MemoryStream( inData ) )
            {
                

                CopyStream( inMemoryStream , outZStream );
                outZStream.finish( );
                return outMemoryStream.ToArray( );
            }
        }

        private void OpenW3Gbtn_Click ( object sender , EventArgs e )
        {
            OpenFileDialog W3GFILE = new OpenFileDialog( );
            W3GFILE.Filter = "Warcraft Replay File|*.w3g";
            W3GFILE.Title = "Please select w3g file...";
            W3GFILE.ShowDialog( );
            inputw3gdata = new List<byte>( File.ReadAllBytes( W3GFILE.FileName ) );
            byte [ ] tmpdata = inputw3gdata.ToArray( );
            MemoryStream memst = new MemoryStream( tmpdata );
            BinaryReader bnread = new BinaryReader( memst );
            byte [ ] oldheader = bnread.ReadBytes( 68 );
            List<byte> outbytes = new List<byte>( );

            try
            {
                int xxxx = 0;
                while ( bnread.BaseStream.Position < bnread.BaseStream.Length )
                {
                    xxxx++;
                    short length = bnread.ReadInt16( );
                    //  MessageBox.Show( length.ToString( ) );
                    short decompressedsize = bnread.ReadInt16( );
                    bnread.ReadInt32( );

                    byte [ ] data = bnread.ReadBytes( length );
                    byte [ ] xoutdata = new byte [ decompressedsize ];

                    zlib.ZStream stream = new zlib.ZStream( );
                    stream.next_in = data;
                    stream.avail_in = data.Length;
                    int initRes = stream.inflateInit( );
                    if ( initRes != 0 )
                    {
                        MessageBox.Show( initRes.ToString( ) );
                    }
                    stream.next_out = xoutdata;
                    stream.avail_out = decompressedsize;
                    int rc = stream.inflate( zlib.zlibConst.Z_SYNC_FLUSH );
                    if ( initRes != 0 )
                    {
                        MessageBox.Show( rc.ToString( ) );
                    }
                    //  MessageBox.Show( xoutdata.Length.ToString());
                    outbytes.AddRange( xoutdata );
                }
            }
            catch
            {

            }

            byte [ ] outdada = outbytes.ToArray( );
            byte [ ] decodada = DecompressData( outdada );


            File.WriteAllBytes( "out.bin" , outbytes.ToArray( ) );
            File.WriteAllBytes( "recompressed.bin" , decodada );
        }
    }
}
