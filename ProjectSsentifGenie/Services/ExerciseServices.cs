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

        public static List<Exercise> GetExercises()
        {
            return pullday;
        }
    }
}
