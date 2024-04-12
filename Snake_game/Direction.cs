namespace Snake_game
{
    public class Direction
    {

        public readonly static Direction left = new Direction(0, -1);
        public readonly static Direction right = new Direction(0, 1);
        public readonly static Direction up = new Direction(-1, 0);
        public readonly static Direction down = new Direction(1, 0);

        public int rowOffset { get; }
        public int columnOffset { get; }

        private Direction(int rowOffset, int columnOffset)
        {
            this.rowOffset = rowOffset;
            this.columnOffset = columnOffset;
        }

        public Direction Opposite()
        {
            return new Direction(-rowOffset, -columnOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   rowOffset == direction.rowOffset &&
                   columnOffset == direction.columnOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(rowOffset, columnOffset);
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
