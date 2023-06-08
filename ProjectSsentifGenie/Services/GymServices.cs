namespace ProjectSsentifGenie.Services
{
    internal class GymServices
    {
        private static readonly List<Gym> gymlist = new()
        {
            new()
            {
                Name = " My Fitness",
                Address = " https://www.myfitness.ee/en/",
                ImageUrl = " https://www.myfitness.ee/wp-content/uploads/2016/06/1324_orig.jpg",
            },

            new()
            {
                Name = " Fitness 24/7",
                Address = " https://www.myfitness.ee/en/",
                ImageUrl = " https://24-7fitness.ee/userfiles/image/list/thumb/keskminekeerukus.jpg",
            },

            new()
            {
                Name = " Lemon Gym",
                Address = " https://www.myfitness.ee/en/",
                ImageUrl = " https://www.lemongym.ee/wp-content/uploads/2023/02/15072022_013.jpg",
            },
        };

        public static List<Gym> GetGymList()
        {
            return gymlist;
        }
    }
}
