namespace DD.Life
{
    public struct Cell
    {
        public bool Alive { get; private set; }
        public Point Point { get; set; }

        public Cell(Point point)
        {
            Point = point;
            Alive = false;
        }

        public void Revive()
        {
            Alive = true;
        }

        public void Kill()
        {
            Alive = false;
        }

        public override string ToString()
        {
            return Alive ? "☻" : "☺";
        }
    }
}