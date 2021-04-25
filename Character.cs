using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_decorator
{
    public interface ICharacter
    {
        string getName();
        string getStyle();
        string getSpecial1();
        string getSpecial2();
    }

    class Male : ICharacter
    {
        public string getName()
        {
            return "Male";
        }

        public string getSpecial1()
        {
            return "Meele";
        }

        public string getSpecial2()
        {
            return "Meele";
        }

        public string getStyle()
        {
            return "No style";
        }
    }

    class Female : ICharacter
    {
        public string getName()
        {
            return "Female";
        }

        public string getSpecial1()
        {
            return "Meele";
        }

        public string getSpecial2()
        {
            return "Meele";
        }

        public string getStyle()
        {
            return "No style";
        }

    }

    public class Alchemist : ICharacter
    {

        private ICharacter character;
        string imgname;

        public Alchemist(ICharacter chara)
        {
            this.character = chara;
            imgname = "Alchemist.png";
        }

        public string getImageName()
        {
            return imgname;
        }

        public virtual string getName()
        {
            return this.character.getName();
        }

        public virtual string getSpecial1()
        {
            return "Dagger";
        }

        public virtual string getSpecial2()
        {
            return "Gun";
        }

        public virtual string getStyle()
        {
            return "Heal";
        }
    }

    public class Gunslinger : ICharacter
    {

        private ICharacter character;
        string imgname;

        public Gunslinger(ICharacter chara)
        {
            this.character = chara;
            imgname = "Gunslinger.png";
        }

        public string getImageName()
        {
            return imgname;
        }

        public virtual string getName()
        {
            return this.character.getName();
        }

        public virtual string getSpecial1()
        {
            return "Gun";
        }

        public virtual string getSpecial2()
        {
            return "Gun";
        }

        public virtual string getStyle()
        {
            return "Special";
        }

    }

    public class Mechanic : ICharacter
    {

        private ICharacter character;
        string imgname;

        public Mechanic(ICharacter chara)
        {
            this.character = chara;
            imgname = "Mechanic.png";
        }

        public string getImageName()
        {
            return imgname;
        }

        public virtual string getName()
        {
            return this.character.getName();
        }

        public virtual string getSpecial1()
        {
            return "Gun";
        }

        public virtual string getSpecial2()
        {
            return "Gun";
        }

        public virtual string getStyle()
        {
            return "Special";
        }

    }

}
