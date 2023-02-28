namespace Flyweight
{
    public partial class Form1 : Form
    {
        FirstDrop frst = new FirstDrop();
        ScndDrop scnd = new ScndDrop();
        ThrdDrop thrd = new ThrdDrop();
        List<Drop> drops = new List<Drop>();
        Random random = new Random();
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (Math.Abs(((int)random.Next(0,3)) % 3)){
                case 0:
                    drops.Add(new Drop(new Point(random.Next(0, this.Width),0), frst));
                    break;
                    case 1:
                    drops.Add(new Drop(new Point(random.Next(0, this.Width), 0), scnd));
                    break;
                default:
                    drops.Add(new Drop(new Point(random.Next(0, this.Width), 0), thrd));
                    break;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < drops.Count; i++)
            {
                g.DrawImage(drops[i].pict.pic, new Rectangle(drops[i].XnY.X, drops[i].XnY.Y, 20, 20));
                
                if (drops[i].XnY.Y >= this.Height) { drops[i].Move(-this.Height); }
                else drops[i].Move(2);

            }
        }
    }
}