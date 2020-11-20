using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    abstract class Product
    {
    }

    class TxtProduct : Product
    {
        public TxtProduct(string path) 
        {
            TxtForm newForm = new TxtForm(path);
            newForm.Text = newForm.Text + $" - {path}";
            newForm.Show();
        }
    }

    class PngProduct : Product
    {
        public PngProduct(string path) 
        {
            PngForm newForm = new PngForm(path);
            newForm.Text = newForm.Text + $" - {path}";
            newForm.Show();
        }
    }

    abstract class Creator
    {
        public string path { get; set; }

        public Creator(string _path)
        {
            path = _path;
        }

        public abstract Product FactoryMethod();
    }

    class TxtCreator : Creator
    {
        public TxtCreator(string path) : base(path)
        { }

        public override Product FactoryMethod() { return new TxtProduct(path); }
    }

    class PngCreator : Creator
    {
        public PngCreator(string path) : base(path)
        { }

        public override Product FactoryMethod() { return new PngProduct(path); }
    }

}
