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
        string getSpecial1();
        string getSpecial2();
    }

    public class Male : ICharacter
    {
        
        private int health { get; set; }
        private int attack { get; set; }
        private int defence { get; set; }
        private int luck { get; set; }

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
    }

    public class Female : ICharacter
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

    }

    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;

        public CharacterDecorator (ICharacter character)
        {
            _character = character;
        }

        public string getName()
        {
            if (this._character != null)
            {
                return this._character.getName();
            }
            else
            {
                return string.Empty;
            }
        }

        public string getSpecial1()
        {
            if (this._character != null)
            {
                return this._character.getSpecial1();
            }
            else
            {
                return string.Empty;
            }
        }

        public string getSpecial2()
        {
            if (this._character != null)
            {
                return this._character.getSpecial2();
            }
            else
            {
                return string.Empty;
            }
        }
    }
    public class Alchemist : CharacterDecorator
    {
        string imgname;

        public Alchemist(ICharacter chara) :base (chara)
        {
            imgname = "Alchemist.png";
        }

        public string getImageName()
        {
            return imgname;
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

        public string getSpecialAttack()
        {
            return "Very special attack";
        }
    }

    public class Gunslinger : CharacterDecorator
    {
        string imgname;

        public Gunslinger(ICharacter chara) : base(chara)
        {
            imgname = "Gunslinger.png";
        }

        public string getImageName()
        {
            return imgname;
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

    public class Mechanic : CharacterDecorator
    {
        string imgname;

        public Mechanic(ICharacter chara) : base(chara)
        {
            imgname = "Mechanic.png";
        }

        public string getImageName()
        {
            return imgname;
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

    public class Nekomancer : CharacterDecorator
    {
        string imgname;

        public Nekomancer(ICharacter chara) : base(chara)
        {
            imgname = "Nekomancer.png";
        }

        public string getImageName()
        {
            return imgname;
        }

        public virtual string getSpecial1()
        {
            return "Staff";
        }

        public virtual string getSpecial2()
        {
            return "Staff";
        }

        public virtual string getStyle()
        {
            return "Special";
        }
    }

    public class Masquerade : CharacterDecorator
    {
        string imgname;

        public Masquerade(ICharacter chara) : base(chara)
        {
            imgname = "Masquerade.png";
        }

        public string getImageName()
        {
            return imgname;
        }

        public virtual string getSpecial1()
        {
            return "Dagger";
        }

        public virtual string getSpecial2()
        {
            return "Dagger";
        }

        public virtual string getStyle()
        {
            return "Attack";
        }
    }

}
