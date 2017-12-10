using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Design a class called Post. This class models a StackOverﬂow post. It should have properties for title, description and the date/time it was created. 
 * We should be able to up-vote or down-vote a post. We should also be able to see the current vote value. 
 * In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value. 
 
   In this exercise, you will learn that a StackOverﬂow post should provide methods for up-voting and down-voting.     You should not give the ability to set the Vote property from the outside, because otherwise, you may accidentally change the votes of a class to 0 or to a random number.     And this is how we create bugs in our programs. The class should always protect its state and hide its implementation detail. 
*/


namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Test post","Test description");
            Console.WriteLine("Post Title: " + post.Title);
            Console.WriteLine("Description: " + post.Description);
            Console.WriteLine("Time: " + post.Created);
            Console.WriteLine("Current Votes: " + post.Votes);

            Console.WriteLine("How many times do you want to Upvote/Downvote");
            var count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {

                Console.WriteLine("Press 1 for up-vote and press 0 for down-vote");
                var input = Convert.ToByte(Console.ReadLine());

                if (input == 1)
                {
                    post.UpVote();
                }
                else
                {
                    post.DownVote();
                }

            }           
             Console.WriteLine("Current Vote Value: " + post.CurrentVote());

        }
    }
}



