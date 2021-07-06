namespace PGA
{
    public class Scene 
    {
        public Background Background {get; set; }
        public Camera Camera {get; set; }
        public Shapes Shapes {get; set; }
        public Lights Lights {get; set; }

        public Scene()
        {
            Camera = new Camera(new Vector(0,0,-5), new Vector(0,0,1));
            Shapes = new Shapes();
            Lights = new Lights();
            Background = new Background(new Color(.2, .2,.0), .1);
        }

    }
}
