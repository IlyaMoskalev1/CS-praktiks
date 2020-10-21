using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Чат
{
    public partial class Main : MaterialForm
    {
        private static Main _instance;

        public static Main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Main();
                return _instance;
            }
        }


        public Panel Content 
            
            {

            get { return MainContainer; }
            set { MainContainer = value; }
            
            }
            




        public Main()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Lime400, Primary.Lime500, Primary.Lime500, Accent.Lime200, TextShade.WHITE);



        }

        private void load_Load(object sender , EventArgs e)
        {
            _instance = this;
            MainContainer.Controls.Add(new UserLogin() { Dock = DockStyle.Fill });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
