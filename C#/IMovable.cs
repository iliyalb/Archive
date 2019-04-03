using System;

namespace Program
{
    interface IMovable
    {
        int Speed { get; }
        void Move(Direction dir);
        void TurnRight();
        void TurnLeft();
        void MoveForward();
        void MoveBackward();
    }

    class Car:IMovable
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Move(Direction dir)
        {

        }

        public void TurnRight()
        {

        }

        public void TurnLeft()
        {

        }

        public void MoveForward()
        {

        }

        public void MoveBackward()
        {

        }
    }
}