using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance.NewFolder1
{
    interface IInterfaceMather
    {
        void Name();

        
    }

    public class cMather_clasic
    {
        public virtual void vName()
        {
            MessageBox.Show("Mother Virtual function");
        }

        public  void uName()
        {
            MessageBox.Show("Mother Usual function");
        }
    }

    public abstract class cMather_abstract
    {

        public abstract void aName();
        
        public  void uName()
        {
            MessageBox.Show("Mother abstract Usual function");
        }

        public virtual void vName()
        {
            MessageBox.Show("Mother abstract Vitrual function");
        }
    }

    public class cChild : cMather_clasic
    {
        public override void vName()
        {
            MessageBox.Show("Child Classic Virtual function");
        }



        
    }

    public class cAbstractChild : cMather_abstract
    {
        public override void aName()
        {
            MessageBox.Show("Child abstract function");
        }

        public override void vName()
        {
            MessageBox.Show("Child abstract Virtual function");
        }

        
    }

    public class cInterfaceClass : IInterfaceMather
    {
        public void Name()
        {
            MessageBox.Show("Child Interface function");
        }
    }


}
