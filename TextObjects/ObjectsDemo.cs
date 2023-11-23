namespace TextObjects
{
    internal class ObjectsDemo
    {
        public static void Run()
        {
            /*
            let model = {
                statObjects: [
                    {numberCount: 25,sum: 123,max: 37,min: 1},
                    {numberCount: 25,sum: 123,max: 37,min: 1},
                    {numberCount: 25,sum: 123,max: 37,min: 1},
                ];
            }
            */
            var model = new StatsModel(new Stats[]
            {
                new Stats(25, 123, 37, 1),
                new Stats(25, 123, 37, 1),
                new Stats(25, 123, 37, 1),
            });



            /*
             let stats = [
                {numberCount: 25,sum: 123,max: 37,min: 1},
                {numberCount: 25,sum: 123,max: 37,min: 1},
                {numberCount: 25,sum: 123,max: 37,min: 1},
             ];
             */
            /*
            var statObjects = new Stats[]
            {
                new Stats(25, 123, 37, 1),
                new Stats(25, 123, 37, 1),
                new Stats(25, 123, 37, 1),
            };
            */

            /*
             let stats = {
                numberCount: 25,
                sum: 123,
                max: 37,
                min: 1,
             }
             */
            /*
            var stats1 = new Stats(25, 123, 37, 1);
            var stats2 = new Stats(52, 321, 37, 1);
            stats1.Show();
            stats2.Show();
            */
        }
    }
}
