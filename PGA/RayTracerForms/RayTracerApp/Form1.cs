using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PGA;
using PGA.Filters;
using Color = PGA.Color;

namespace RayTracerApp
{
    public partial class Form1 : Form
    {
        private bool _isTracing;
        private Scene _scene = new Scene();
        private int sceneId;
        Texture _marbleTexture;
        Texture _woodTexture;
        Texture _wallTexture;
        Bitmap _bitmap;

        public Form1()
        {
            InitializeComponent();
            _isTracing = false;
        }

        #region Setup scene

        private void SetupScene2()
        {
            _scene = new Scene();
            _scene.Background = new Background(new Color(.2, .3, .4), 0.5);
            Vector campos = new Vector(0, 0, -5);
            _scene.Camera = new Camera(campos, campos / -2, new Vector(0, 1, 0).Normalize());

            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {

                _scene.Shapes.Add(new SphereShape(new Vector(rnd.Next(-100, 100) / 50.0, rnd.Next(-100, 100) / 50.0, rnd.Next(0, 200) / 50.0), .2,
                                   new SolidMaterial(new Color(rnd.Next(0, 100) / 100.0, rnd.Next(0, 100) / 100.0, rnd.Next(0, 100) / 100.0), 0.4, 0.0, 2.0)));

            }

            _scene.Lights.Add(new Light(new Vector(5, 10, -1), new Color(0.8, 0.8, 0.8)));
            _scene.Lights.Add(new Light(new Vector(-3, 5, -15), new Color(0.8, 0.8, 0.8)));

        }


        private void SetupScene1()
        {

            TextureMaterial woodMaterial = new TextureMaterial(_woodTexture, 0.2, 0.0, 2, .5);
            TextureMaterial marbleMaterial = new TextureMaterial(_marbleTexture, 0.0, 0.0, 2, .5);
            TextureMaterial wallMaterial = new TextureMaterial(_wallTexture, 0.0, 0.0, 2, .4);


            _scene = new Scene();
            _scene.Background = new Background(new Color(.8, .8, .8), 0.8);
            Vector campos = new Vector(5, 1.8, -15);
            _scene.Camera = new Camera(campos, campos / -3, new Vector(0, 1, 0).Normalize());

            _scene.Shapes.Add(new SphereShape(new Vector(1, 1, -5), 1,
                               marbleMaterial));

            _scene.Shapes.Add(new PlaneShape(new Vector(0, 1, 0).Normalize(), 0, woodMaterial));
            _scene.Shapes.Add(new PlaneShape(new Vector(0, 0, 1).Normalize(), 0, wallMaterial));

            _scene.Lights.Add(new Light(new Vector(25, 20, -20), new Color(0.5, 0.5, 0.5)));
            _scene.Lights.Add(new Light(new Vector(-3, 5, -15), new Color(0.5, 0.5, 0.5)));
        }

        private void SetupScene4()
        {

            TextureMaterial woodMaterial = new TextureMaterial(_woodTexture, 0.0, 0.0, 2, .5);
            TextureMaterial marbleMaterial = new TextureMaterial(_marbleTexture, 0.3, 0.0, 2, .5);
            TextureMaterial wallMaterial = new TextureMaterial(_wallTexture, 0.0, 0.0, 2, .4);


            _scene = new Scene();
            _scene.Background = new Background(new Color(.3, .8, .8), 0.8);
            Vector campos = new Vector(14, 2, -6);
            _scene.Camera = new Camera(campos, campos / -2.5, new Vector(-0, 1, 0.1).Normalize());

            _scene.Shapes.Add(new SphereShape(new Vector(-3, 1, 5), 2,
                               marbleMaterial));

            _scene.Shapes.Add(new SphereShape(new Vector(0, 1, -1), 1,
                               woodMaterial));

            _scene.Shapes.Add(new PlaneShape(new Vector(0, 1, 0).Normalize(), 0, wallMaterial));


            _scene.Lights.Add(new Light(new Vector(25, 20, -20), new Color(0.5, 0.5, 0.5)));
            _scene.Lights.Add(new Light(new Vector(-23, 25, -15), new Color(0.5, 0.5, 0.5)));
        }

        private void SetupScene3()
        {

            TextureMaterial texture = new TextureMaterial(_marbleTexture, 0.0, 0.0, 2, .5);

            _scene = new Scene();
            _scene.Camera = new Camera(new Vector(0, 0, -15), new Vector(-.2, 0, 5), new Vector(0, 1, 0));

            _scene.Shapes.Add(new SphereShape(new Vector(-1.5, 0.5, 0), .5,
                new SolidMaterial(new Color(0, .5, .5), 0.2, 0.0, 2.0)));

            _scene.Shapes.Add(new SphereShape(new Vector(0, 0, 0), 1, new SolidMaterial(new Color(1, .3, .3), 0.0, 0.0, 0.0)));//texture));

            _scene.Shapes.Add(new PlaneShape(new Vector(0.1, 0.9, -0.5).Normalize(), 1.2,
                new SolidMaterial(new Color(1,1, 1), 0.0, 0.0, 0.0)));
            //new ChessboardMaterial(new Color(1, 1, 1), new Color(0, 0, 0), 0.2, 0, 1, 0.7)));
            //_scene.Lights.Add(new Light(new Vector(5, 10, -1), new Color(0.8, 0.0, 0.0)));
            //_scene.Lights.Add(new Light(new Vector(5, 10, -1), new Color(0.8, 0.8, 0.8)));
            _scene.Lights.Add(new Light(new Vector(-15, 8, -15), new Color(0.8, 0.8, 0.8)));

        }

        private void SetupScene0()
        {
            TextureMaterial texture = new TextureMaterial(_marbleTexture, 0.0, 0.0, 2, .5);

            _scene = new Scene();
            _scene.Camera = new Camera(new Vector(0, 0, -15), new Vector(-.2, 0, 5), new Vector(0, 1, 0));

            _scene.Shapes.Add(new SphereShape(new Vector(-1.5, 0.5, 0), .5,
                               new SolidMaterial(new Color(0, .5, .5),.2, .2, 2.0)));

            _scene.Shapes.Add(new SphereShape(new Vector(0, 0, 0), 1, 
                new SolidMaterial(new Color(1, .3, .3), 0.5, 0.0, 0.0)));//texture));

            _scene.Shapes.Add(new PlaneShape(new Vector(0.1, 0.9, -0.5).Normalize(), 1.2,
                                new SolidMaterial(new Color(1,1, 1), 0.2, 0.2, 0.2)));
                               //new ChessboardMaterial(new Color(1, 1, 1), new Color(0, 0, 0), 0.2, 0, 1, 0.7)));
            //_scene.Lights.Add(new Light(new Vector(5, 10, -1), new Color(0.8, 0.0, 0.0)));
            //_scene.Lights.Add(new Light(new Vector(5, 10, -1), new Color(0.8, 0.8, 0.8)));
            _scene.Lights.Add(new Light(new Vector(-6, 5, -15), new Color(0.8, 0.8, 0.8)));
            foreach (var light in _scene.Lights)
            {
                //light.strength = 5;
            }

        }

        #endregion Setup scene

        void tracer_RenderUpdate(int scanline)
        {
            pbScene.Invalidate(new Rectangle(0, scanline - 1, pbScene.Image.Width, 2));
            Application.DoEvents();
        }

        private void pbScene_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void renderNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbMainPanel.Checked)
                pbScene.Image = RenderImage(cbMainPanel.Width, cbMainPanel.Height);
            if (cbSecondaryPanel.Checked)
                pbSecondaryScene.Image = RenderImage(pbSecondaryScene.Width, pbSecondaryScene.Height);
        }

        private Bitmap RenderImage(int Width, int Height)
        {
           // label1.Visible = false;
            toolStripStatusLabel1.Text = "Rendering...";
            toolStripStatusLabel1.Invalidate();
            if (_isTracing) return null;
            
            _isTracing = true;

            switch (sceneId)
            {
                case 0:
                    SetupScene0();
                    break;
                case 1:
                    SetupScene1();
                    break;
                case 2:
                    SetupScene2();
                    break;
                case 3:
                    SetupScene3();
                    break;
                default:
                    SetupScene4();
                    break;
            }

            PGA.RayTracer raytracer = new PGA.RayTracer(
                cbRenderDiffuse.Checked,
                cbPhongHighlight.Checked,
                cbCastShadow.Checked,
                cbShowReflections.Checked,
                cbShowRefractions.Checked,
                cbCellShading.Checked);
            Rectangle rect = new Rectangle(0, 0, pbScene.Width, pbScene.Height);
            _bitmap = new Bitmap(rect.Width, rect.Height);

            Graphics g = Graphics.FromImage(_bitmap);

            var filters = new List<IFilter>();
            if(cbApplyHDR.Checked)
                filters.Add(new HDR());
            if (cbDetectBorders.Checked)
                filters.Add(new BorderDetection());
            if(cbApplyBlur.Checked)
                filters.Add(new Blur());
            if (cbApplySobell.Checked)
                filters.Add(new Sobel());

            ImageProcess r = new ImageProcess(_scene,raytracer);
            r.Execute(g, rect,filters.ToArray());
            _isTracing = false;
            toolStripStatusLabel1.Text = "Done";
            return  _bitmap;
        }

        private void CheckMenuScene(object sender)
        {
            marbleSpheresToolStripMenuItem.Checked = marbleSpheresToolStripMenuItem.Equals(sender);
            woodenFloorAndStoneWallToolStripMenuItem.Checked = woodenFloorAndStoneWallToolStripMenuItem.Equals(sender);
            randomMarblesToolStripMenuItem.Checked = randomMarblesToolStripMenuItem.Equals(sender);
        }

        private void marbleSpheresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuScene(sender);
            sceneId = 0;
        }

        private void woodenFloorAndStoneWallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuScene(sender);
            sceneId = 1;
        }

        private void randomMarblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuScene(sender);
            sceneId = 2;
        }

        private void reflectiveShereOnChessboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuScene(sender);
            sceneId = 3;
        }

        private void woodenBoxAndMarbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuScene(sender);
            sceneId = 4;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(_bitmap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Visible = true;
            Application.DoEvents();

            string path = Application.StartupPath;

            _woodTexture = Texture.FromFile(path + @"\wood2.png");
            _marbleTexture = Texture.FromFile(path + @"\marble1.png");
            _wallTexture = Texture.FromFile(path + @"\wall1.png");
        }

        private void pbScene_Click(object sender, EventArgs e)
        {

        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cellShadingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Depth_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbApplyHDR_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}