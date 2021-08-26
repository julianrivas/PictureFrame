using Domain.Properties;

namespace Domain.Frames
{
    public abstract class Frame
    {
        public abstract int Id { get; }
        public abstract string Description { get; }
        public abstract BorderFrame BorderFrame { get; }
        public abstract CornerFrame CornerFrame { get; }
    }

    public class DarkFrame : Frame
    {
        public override int Id => 1;

        public override string Description => "Dark Frame";

        public override BorderFrame BorderFrame => new ()
        {
            UpImage = Resources.F001USide,
            DownImage = Resources.F001DSide,
            LeftImage = Resources.F001LSide,
            RightImage = Resources.F001RSide
        };

        public override CornerFrame CornerFrame => new ()
        { 
            UpLeftImage = Resources.F001ULCorner,
            UpRightImage = Resources.F001URCorner,
            DownLeftImage = Resources.F001DLCorner,
            DownRightImage = Resources.F001DRCorner
        };
    }
}
