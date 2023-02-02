namespace ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods
{
    public class Singleton
    {
        private static Singleton instance = null;

        protected Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}
