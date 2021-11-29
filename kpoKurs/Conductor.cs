namespace kpoKurs
{
    class Conductor
    {
        protected double r;
        protected double i;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    r = value;
                }
            }
        }
        public double I
        {
            get
            {
                return i;
            }

            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    i = value;
                }
            }
        }
    }
}

