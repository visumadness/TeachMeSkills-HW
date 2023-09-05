using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramEmulator
{
    public class User
    {
        private List<Post> myPosts;
        private List<Post> postsToSee;
        private int myPostsLimit;
        private int postsToSeeLimit;

        public event Action<Post> NewPostAdded;

        public User(int myPostsLimit, int postsToSeeLimit)
        {
            this.myPostsLimit = myPostsLimit;
            this.postsToSeeLimit = postsToSeeLimit;
            myPosts = new List<Post>();
            postsToSee = new List<Post>(); 
        }

        public void AddPost(Post post)
        {
            if(myPosts.Count >= myPostsLimit)
            {
                Console.WriteLine("Your own post limit has been exceeded. The post will be ignored.");
                return;
            }

            postsToSee.Add(post);
            NewPostAdded?.Invoke(post);
        }

        private void AddToPostsToSee(Post post)
        {
            if (postsToSee.Count >= postsToSeeLimit)
            {
                Console.WriteLine("The limit of posts for viewing has been exceeded. The post will be ignored.");
                return;
            }

            postsToSee.Add(post);
        }

        public void Subscribe(User user)
        {
            user.NewPostAdded += AddToPostsToSee;
        }

        public void Unsubscribe(User user)
        {
            user.NewPostAdded -= AddToPostsToSee;
        }
    }
}
