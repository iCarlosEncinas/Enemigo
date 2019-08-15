using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1GameEnemy
{
    class Enemigo
    {

        object Enemy { get; set; }
        
        #region Position
        private int _eposX;
        public int EposX
        {
            get
            {
                return EposX;
            }
            set
            {
                if (EposX > 500)
                    EposX = EposX * -1;
                else
                    EposX = EposX * 1;
            }
        }

        private int _eposY;
        public int EposY
        {
            get
            {
                return EposY;
            }
            set
            {
                if (EposY > 500)
                    EposY = EposY * -1;
                else
                    EposY = EposY * 1;
            }
        
        }
        #endregion


        #region Score and Life
        private int _score;
        public int Score
        {
            get
            {
                return Score;
            }
            set
            {
                if (_life == 0)
                    _score = 100;
            }
        }

        private int _life;
        public int Life
        {
            get
            {
                return Life
            }
            set
            {
                _life = 100;

            }
        }
        #endregion


        #region Funciones de Enemigo
        public void Move()
        {
            
        }

        public void Shoot()
        {

        }

        public void Destruirse()
        {
            
        }
        #endregion

    }
}
