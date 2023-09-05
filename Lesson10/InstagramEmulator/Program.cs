using InstagramEmulator;

class Program
{
    static void Main(string[] args)
    {
        // создаем пользователей
        User user1 = new User(3, 5) { Name = "User1" };
        User user2 = new User(2, 3) { Name = "User2" };
        User user3 = new User(1, 2) { Name = "User3" };

        // связываем пользователей между собой (user1 подписывается на user2, user2 подписывается на user3 и user1)
        user1.AddFollower(user2);
        user2.AddFollower(user3);
        user2.AddFollower(user1);

        // пользователи добавляют новые посты
        user1.AddPost(new Post("Post 1 by user1", DateTime.Now, user1));
        user2.AddPost(new Post("Post 1 by user2", DateTime.Now, user2));
        user3.AddPost(new Post("Post 1 by user3", DateTime.Now, user3));
        user2.AddPost(new Post("Post 2 by user2", DateTime.Now, user2));
        user2.AddPost(new Post("Post 3 by user2", DateTime.Now, user2));
        user1.AddPost(new Post("Post 2 by user1", DateTime.Now, user1));
        user1.AddPost(new Post("Post 3 by user1", DateTime.Now, user1));
        user2.AddPost(new Post("Post 4 by user2", DateTime.Now, user2));
        user3.AddPost(new Post("Post 2 by user3", DateTime.Now, user3));
        user2.AddPost(new Post("Post 5 by user2", DateTime.Now, user2));
        user2.AddPost(new Post("Post 6 by user2", DateTime.Now, user2));

        // выводим список постов каждого пользователя
        user1.PrintPosts();
        user2.PrintPosts();
        user3.PrintPosts();
    }
}
