using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSsentifGenie.Services
{
    internal class ExerciseServices
    {
        private static readonly List<Exercise> pullday = new()
        {
            new()
            {
                Name = " Pull-Ups",
                GroupType = " Back Exercise",
                Instructions = " Start by gripping a pull-up bar with your knuckles facing towards your face and your arms fully extended.\r\nBend your knees and cross your feet behind you.\r\nPull yourself up until your chin is above the bar.\r\nLower yourself back into the starting posture.\r\nRepeat for the desired number of repetitions.\r\nTips: Make sure to extend your arms for an optimal range of motion fully. If you can do more than 12 repetitions, try adding weight by wearing a weight belt or holding a dumbbell between your feet.",
                ImageUrl = " https://i.shgcdn.com/02a8623c-c7a9-4480-afa3-a52d1b7bb819/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Deadlifts",
                GroupType = " Back, Legs & Core Exercise",
                Instructions = " Start by standing with your feet shoulder-width apart and a slight bend in your knees.\r\nBend your hips and knees while holding the bar and position your hands roughly shoulder-width apart.\r\nKeeping your back straight, lift the bar off the ground and stand up.\r\nLower the bar back to the ground and repeat for the desired number of repetitions.\r\nTips: If you cannot do a deadlift with proper form, try doing them with a lighter weight or try using a trap bar.",
                ImageUrl = " https://i.shgcdn.com/db0c82d5-e90a-469f-9145-e5370594e7b0/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Lat Pulldowns",
                GroupType = " Lats Exercise",
                Instructions = " Start by sitting on a lat pulldown machine with your knees bent and your feet flat on the floor.\r\nReach up and grab the bar with your palms facing away from you and your hands shoulder-width apart.\r\nPull the bar down to your chest, keeping your back straight and your elbows in.\r\nSlowly return the bar and repeat the motion for the desired number of repetitions.\r\nTips: Make sure to stretch your arms at the top to activate the lats optimally. Go all the way down to your upper chest and repeat.",
                ImageUrl = " https://i.shgcdn.com/4a56b60f-112a-4090-b9c0-2bdb4b7891ac/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Barbell Rows",
                GroupType = " Back & Lats Exercise",
                Instructions = " Start by standing with your feet shoulder-width apart and a slight bend in your knee.\r\nBend at your hips and grip the bar with your hands shoulder-width apart.\r\nKeeping your back straight, lower your torso until it is parallel to the floor.\r\nRow the bar up to your abdominals, keeping your elbows tucked in.\r\nReturn the bar and repeat the motion for the desired number of repetitions.\r\nTips: If you struggle to lift the weight while bending over, use a lighter weight or an assisted rowing machine until you master the motion.",
                ImageUrl = " https://i.shgcdn.com/bfc65d2d-a773-471c-bfa5-c892aaad03b5/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Dumbbell Rows",
                GroupType = " Back & Lats Exercise",
                Instructions = " Start by standing with your feet hip-width apart and one knee resting on a bench.\r\nBend at your hips while holding a dumbbell in each hand. Place the other hand on the bench for support.\r\nKeeping your back straight, lower your torso until your body is at a 45-degree angle.\r\nPull the dumbbell up to your chest, keeping your elbow close to your side.\r\nLower the dumbbell back to the starting position and repeat for the desired number of repetitions.\r\nTips: If you'd prefer to row using both arms simultaneously, simply stand with a slight bend in your knees and lean forward until your waist is at a 45-degree angle.",
                ImageUrl = " https://i.shgcdn.com/7b4bd650-1a0b-49ad-bef0-ec4f1331c6e9/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Pullovers",
                GroupType = " Chest & Lats Execise",
                Instructions = " Start by lying on a bench with your knees bent and your feet flat on the floor.\r\nHold the dumbbell with your palms facing away from you and your hands roughly shoulder-width apart.\r\nRaise the weight over your head while keeping your arms straight.\r\nBend your arms at the elbows and lower the weights until they are completely behind you.\r\nRaise the weight back over your head and repeat for the desired number of repetitions.\r\nTips: If you're using a dumbbell, hold it with both hands.",
                ImageUrl = " https://i.shgcdn.com/def0b7e3-4e54-43ed-8cc1-1a680ada92bc/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Dumbbell Shrugs",
                GroupType = " Trapezius Exercise",
                Instructions = " Start by standing with your feet hip-width apart and your knees slightly bent.\r\nHold a dumbbell in each hand, with your curled fingers facing the sides of your thighs.\r\nKeeping your arms straight, lift your shoulders up to your earlobes.\r\nLower your shoulders and repeat for the desired number of repetitions.\r\nTips: Make sure to squeeze the trapezius and lift your shoulders up to your ears for maximum contraction.",
                ImageUrl = " https://i.shgcdn.com/60d2968b-8ffa-40e6-94a1-d3c16e2eb940/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Face Pulls",
                GroupType = " Shoulder Exercise",
                Instructions = " Start by standing with your feet hip-width apart and your knees slightly bent.\r\nGrip the cable with your palms facing away from you and your hands shoulder-width apart.\r\nPull the cable towards your face, keeping your elbows close to your sides.\r\nSlowly return the cable to the starting position and repeat for the desired number of repetitions.\r\nTips: If you're having trouble keeping your arms straight, try using a lighter weight.",
                ImageUrl = " https://i.shgcdn.com/e65e714c-b8fb-4c7c-8633-d232a4ee71fa/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Barbell Biceps Curls",
                GroupType = " Biceps Exercise",
                Instructions = " Start by standing with your feet hip-width apart.\r\nGrip a barbell in your hand with your palms facing your thighs.\r\nWith your elbows tucked into your sides, lift the barbell towards your shoulders.\r\nLower the weights back down to the starting position and repeat for the desired number of repetitions.\r\nTips: If you don't like using barbells, you can use dumbbells to work your biceps individually.",
                ImageUrl = " https://i.shgcdn.com/0d4cbf81-19e6-4ce2-ba5b-990ba801a5ef/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Dumbbell Preacher Curls",
                GroupType = " Biceps Exercise",
                Instructions = " Start by sitting on a preacher curl bench with your feet flat on the floor.\r\nGrip a dumbbell in each hand with your palms facing your thighs.\r\nRest your arms on the pad in front of you and curl the weights up to your shoulders.\r\nLower the weights back down to the starting position and repeat for the desired number of repetitions.\r\nTips: Fully extend your arms nearly all the way down to activate the biceps completely.",
                ImageUrl = " https://i.shgcdn.com/a382e76d-6ca2-4275-b346-9e83dae0223a/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Cable Curls",
                GroupType = " Biceps Exercise",
                Instructions = " Start by standing with your feet hip-width apart.\r\nGrip the cable with your palms facing away from you and your hands shoulder-width apart.\r\nKeeping your elbows close to your sides, curl the cable up to your shoulders.\r\nLower the cable back down to the starting position and repeat for the desired number of repetitions.\r\nTips: We recommend using individual attachment to isolate your bicep muscles specifically.",
                ImageUrl = " https://i.shgcdn.com/16f1da3e-1670-466b-98ff-4a18143c63dd/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

        };

        private static readonly List<Exercise> pushday = new()
        {
            new()
            {
                Name = " Flat Dumbbell Bench Press",
                GroupType = " Chest Exercise",
                Instructions = " 1. Lie on your back on a flat bench with a dumbbell in each hand.\r\n 2. Press the dumbbells up until your arms are straight.\r\n 3. Lower the dumbbells down until your arms are at a 90-degree angle. You may go slightly lower until you get a good stretch.\r\n 4. Press the dumbbells back up until your arms are straight. Repeat for the desired number of repetitions.\r\nTips: Make sure to keep your back flat on the bench and your feet flat on the floor. Try to go heavy on this exercise while still maintaining good form.",
                ImageUrl = "https://i.shgcdn.com/0c1706b0-37a5-48a4-b1b6-9c732b5d02d2/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Incline Bench Press",
                GroupType = " Chest Exercise",
                Instructions = " 1. Lie on your back on an incline bench with a barbell positioned above you. " +
                "Squeeze your shoulder blades together tightly to create a solid and stable position on the bench.\r\n 2. Lift the weight upward until your arms are straight.\r\n 3. Lower the weight down until it is a few inches away from touching your chest.\r\n 4. Press the weights back up until your arms are straight. Repeat for the desired number of repetitions.\r\nTips: Make sure to keep your back flat on the bench and your feet flat on the floor. Shifting around can cause injuries and indicates that the weight is too heavy.",
                ImageUrl = "https://i.shgcdn.com/fb804e90-1738-4f87-a46c-d01040b3a76e/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Dips",
                GroupType = " Chest & Triceps Exercise",
                Instructions = " 1. Position yourself on a dip station or a chair with your hands shoulder-width apart.\r\n 2. Extend your legs out in front of you at a 45-degree angle.\r\n 3. Lower your body down by bending your elbows until they reach a 90-degree angle. You don't have to go all the way to 90-degrees but try to get as close as possible.\r\n 4. Press your body back up until your arms are straight. Repeat for the desired number of repetitions.\r\nTips: Keep your back straight and avoid rounding your shoulders as you dip down. You may feel the urge to lean your head forward but try your best to keep your head up.",
                ImageUrl = "https://i.shgcdn.com/7f0fb43c-f324-4a00-b46b-5f631e853509/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Triceps Pushdown",
                GroupType = " Triceps Exercise",
                Instructions = " 1. Attach a horizontal cable bar to the pulley machine.\r\n 2. Grip the bar with your hands positioned shoulder-width apart.\r\n 3. Keeping your elbows close to your sides, push the bar down until your arms are fully extended.\r\n 4. Release the tension and allow your arms to return to the starting position. Repeat for the desired number of repetitions.\r\nTips: Avoid swinging your arms as you push the bar down as this can lead to injury. Instead, focus the weight throughout your triceps and push down along your sternum.",
                ImageUrl = "https://i.shgcdn.com/9717db44-3098-49f1-8ad5-2def26d58c7e/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Skullcrushers",
                GroupType = " Triceps Exercise",
                Instructions = " 1. Lie down on a flat bench with a barbell or dumbbells positioned above your chest.\r\n 2. Grip the EZ bar or dumbbells with your hands shoulder-width apart or slightly closer.\r\n 3. Keeping your elbows close to your sides, lower the weight down until it is at your forehead.\r\n 4. Press the weight back up until your arms are straight. Repeat for the desired number of repetitions.\r\nTips: Avoid swinging the weight backward as you lower the weight down. This exercise requires a lot of control to avoid injury. If the weight is too heavy for you to bring it back without swinging it, go lighter!",
                ImageUrl = "https://i.shgcdn.com/065ff229-5149-45e8-a157-4dd80ac5df85/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Seated Triceps Extensions",
                GroupType = " Triceps Exercise",
                Instructions = " 1. Sit on a bench or chair with a dumbbell positioned behind your head.\r\n 2. Grip the weight with both hands and press it up until your arms are fully extended.\r\n 3. Keeping your elbows close to your sides, lower the weight down until it is at your forehead.\r\n 4. Press the weight back up until your arms are straight. Repeat for the desired number of repetitions.\r\nTips: As with the other tricep exercises, focus on keeping your elbows close to your sides to really target the muscle group. You may feel the urge to arch your back but try your best to keep your back flat against the bench.",
                ImageUrl = "https://i.shgcdn.com/a8bf95d4-6832-4770-b326-358c1063a400/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Dumbbell Shoulder Press",
                GroupType = " Shoulder Exercise",
                Instructions = " 1. Sit on an upright bench with a dumbbell in each hand.\r\n 2. Position the weights at your shoulders with your palms facing forward.\r\n 3. Press the dumbbells up until your arms are straight.\r\n 4. Lower the dumbbells down until they are at a 90-degree angle.\r\n 5. Press the dumbbells back up until your arms are straight. Repeat for the desired number of repetitions.\r\nTips: As with the other exercises, keep your back straight and avoid rounding your shoulders. You may feel the urge to lean your head forward but try your best to keep your head up.",
                ImageUrl = "https://i.shgcdn.com/8cdd4abd-0c5a-46f0-aad3-462c9cf9a49f/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },

            new()
            {
                Name = " Side Lateral Raises",
                GroupType = " Shoulder Exercise",
                Instructions = " 1. Stand with your feet shoulder-width apart with a dumbbell in each hand.\r\n 2. Raise your arms out to the side until they are at shoulder height or slightly higher.\r\n 3. Lower your arms back down to your sides. Repeat for the desired number of repetitions.\r\nTips: Avoid swinging your arms as you raise them up as this can lead to injury. Instead, focus on using your shoulder muscles to lift the weight up using a controlled motion.",
                ImageUrl = "https://i.shgcdn.com/3e7857c6-291e-4121-a9e6-af10f39affc9/-/format/auto/-/preview/3000x3000/-/quality/lighter/",
            },
        };

        public static List<Exercise> GetPullExercises()
        {
            return pullday;
        }

        public static List<Exercise> GetPushExercises()
        {
            return pushday;
        }
    }
}
