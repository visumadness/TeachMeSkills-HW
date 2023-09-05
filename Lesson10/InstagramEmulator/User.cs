using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramEmulator
{
    class User
    {
        private int myPostsLimit;
        private int postsToSeeLimit;
        private List<User> followers = new List<User>(); // список подписчиков
        private List<Post> myPosts = new List<Post>(); // список собственных постов
        private List<Post> postsToSee = new List<Post>(); // список постов подписок

        public User(int myPostsLimit, int postsToSeeLimit)
        {
            this.myPostsLimit = myPostsLimit;
            this.postsToSeeLimit = postsToSeeLimit;
        }

        public string Name { get; set; }

        public void AddFollower(User follower)
        {
            followers.Add(follower);
        }

        public void AddPost(Post post)
        {
            if (myPosts.Count >= myPostsLimit)
            { 
                Console.WriteLine($"Error: Can't add post '{post.Caption}' from user '{Name}'. Exceeded my posts limit");
            }
            else
            {
                myPosts.Add(post); // добавляем пост в свой список постов
                Console.WriteLine($"New post '{post.Caption}' added by '{Name}'");

                // уведомляем всех подписчиков о новом посте
                foreach (User follower in followers)
                {
                    follower.OnNewPostAdded(post);
                }
            }
        }

        // метод вызывается, когда пользователь получает уведомление о новом посте от другого пользователя
        public void OnNewPostAdded(Post post)
        {
            if (postsToSee.Count >= postsToSeeLimit)
            { // проверяем лимит на количество постов для просмотра
                Console.WriteLine($"Can't add post '{post.Caption}' from user '{Name}' to posts to see list of user '{this.Name}'. Exceeded posts to see limit");
            }
            else
            {
                postsToSee.Add(post); // добавляем пост в список постов для просмотра
                Console.WriteLine($"New post '{post.Caption}' added to posts to see list of user '{Name}'");
            }
        }

        // метод для вывода списка своих постов и постов подписок
        public void PrintPosts()
        {
            Console.WriteLine($"My posts ({myPosts.Count}):");
            foreach (Post post in myPosts)
            {
                Console.WriteLine($"{post.Caption} ({post.Date.ToString()})");
            }

            Console.WriteLine($"Posts to see ({postsToSee.Count}):");
            foreach (Post post in postsToSee)
            {
                Console.WriteLine($"{post.User.Name}: {post.Caption} ({post.Date.ToString()})");
            }
        }
    }
}
