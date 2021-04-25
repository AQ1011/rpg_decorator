using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_decorator
{
    public partial class Form1 : Form
    {

        ICharacter myCharacter;
        string path;

        public Form1()
        {
            InitializeComponent();
            myCharacter = new Male();
            string[] characterClass = { "Alchemist", "Gunslinger", "Mechanic", "Nekomancer", "Marquerade"};

            path = "../../";

            //default
            comboBox1.Items.AddRange(characterClass);
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void setAlchemist()
        {
            Alchemist chara = new Alchemist(myCharacter);
            string imgPath = path + "characters/" + chara.getName() + "/" + chara.getImageName();
            pictureBox1.Image = new Bitmap(imgPath);
            pb_spec1.Image = new Bitmap(path + "special/" + chara.getSpecial1() + ".png");
            pb_spec2.Image = new Bitmap(path + "special/" + chara.getSpecial2() + ".png");
            pb_style.Image = new Bitmap(path + "style/" + chara.getStyle() + ".png");
        }

        private void setGunslinger()
        {
            Gunslinger chara = new Gunslinger(myCharacter);
            string imgPath = path + "characters/" + myCharacter.getName() + "/" + chara.getImageName();
            pictureBox1.Image = new Bitmap(imgPath);
            pb_spec1.Image = new Bitmap(path + "special/" + chara.getSpecial1() + ".png");
            pb_spec2.Image = new Bitmap(path + "special/" + chara.getSpecial2() + ".png");
            pb_style.Image = new Bitmap(path + "style/" + chara.getStyle() + ".png");
        }

        private void setMechanic()
        {
            Mechanic chara = new Mechanic(myCharacter);
            string imgPath = path + "characters/" + myCharacter.getName() + "/" + chara.getImageName();
            pictureBox1.Image = new Bitmap(imgPath);
            pb_spec1.Image = new Bitmap(path + "special/" + chara.getSpecial1() + ".png");
            pb_spec2.Image = new Bitmap(path + "special/" + chara.getSpecial2() + ".png");
            pb_style.Image = new Bitmap(path + "style/" + chara.getStyle() + ".png");
        }


        private void setNekomancer()
        {
            Nekomancer chara = new Nekomancer(myCharacter);
            string imgPath = path + "characters/" + myCharacter.getName() + "/" + chara.getImageName();
            pictureBox1.Image = new Bitmap(imgPath);
            pb_spec1.Image = new Bitmap(path + "special/" + chara.getSpecial1() + ".png");
            pb_spec2.Image = new Bitmap(path + "special/" + chara.getSpecial2() + ".png");
            pb_style.Image = new Bitmap(path + "style/" + chara.getStyle() + ".png");
        }

        private void setMarquerade()
        {
            Masquerade chara = new Masquerade(myCharacter);
            string imgPath = path + "characters/" + myCharacter.getName() + "/" + chara.getImageName();
            pictureBox1.Image = new Bitmap(imgPath);
            pb_spec1.Image = new Bitmap(path + "special/" + chara.getSpecial1() + ".png");
            pb_spec2.Image = new Bitmap(path + "special/" + chara.getSpecial2() + ".png");
            pb_style.Image = new Bitmap(path + "style/" + chara.getStyle() + ".png");
        }

        public void setImage() { 
        }

        private void setClass()
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Alchemist":
                    setAlchemist();
                    break;
                case "Gunslinger":
                    setGunslinger();
                    break;
                case "Mechanic":
                    setMechanic();
                    break;
                case "Nekomancer":
                    setNekomancer();
                    break;
                case "Marquerade":
                    setMarquerade();
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
            myCharacter = new Male();
            setClass();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
            myCharacter = new Female();
            setClass();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setClass();
        }
    }
}
