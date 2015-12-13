namespace PongGame
{
    public class CollisionDetector
    {
        /// <summary> 
        /// Calculates if rectangles describing two sprites 
        /// are overlapping on screen.
        /// </summary>
        /// <param name="s1">First sprite</param>
        /// <param name="s2">Second sprite</param> 
        /// <returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            if (s1.Position.Y == s2.Position.Y)
            {
                if (s1.Position.X == s2.Position.X - (s2.Size.Width / 2) 
                    || s1.Position.X == s2.Position.X + (s2.Size.Width / 2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
