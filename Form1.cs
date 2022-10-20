namespace WFA221020
{
    public partial class Form1 : Form
    {
        static Random rnd = new();
        int miss = 0;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Kattintas(object sender, EventArgs e)
        {
            DialogResult res =  MessageBox.Show(
                caption: "ELSÕ PROGRAM",
                text: "Do you like pink color?",
                icon: MessageBoxIcon.Information,
                buttons: MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                button1.BackColor = Color.Magenta;
                this.BackColor = Color.LightPink;
            }
            else
            {
                this.Close();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            miss++;
            button1.Location = new Point(
                x: rnd.Next(0, this.Width - button1.Width),
                y: rnd.Next(0, this.Height - button1.Height));
            lblCounter.Text = $"{miss}";

            this.BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}