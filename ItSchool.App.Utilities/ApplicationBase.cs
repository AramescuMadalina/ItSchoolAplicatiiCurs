namespace ItSchool.App.Utilities
{
    public abstract class ApplicationBase
    {
        // unica in tot softul meu 
        public static List<ApplicationBase> Applications = new List<ApplicationBase>();
        public string Cerinta;

        protected ApplicationBase()
        {


        }

        public abstract void Launch();
    }
}
