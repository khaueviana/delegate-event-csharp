namespace KV.DelegateEvent
{
    public class Figura
    {
        public delegate void FiguraHandler(string msg);

        public static event FiguraHandler Invertido;

        public Figura(float a, float b, float c)
        {
            m_xPos = a;
            m_yPos = b;
            m_zPos = c;
        }

        public void InverterX()
        {
            m_xPos = -m_xPos;
        }

        public void InverterY()
        {
            m_yPos = -m_yPos;
        }

        public void InverterZ()
        {
            m_zPos = -m_zPos;

            Invertido("invertida pelo eixo Z!");
        }

        private float m_xPos = 0;

        private float m_yPos = 0;

        private float m_zPos = 0;
    }
}