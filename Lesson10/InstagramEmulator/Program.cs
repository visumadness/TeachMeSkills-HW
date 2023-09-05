using InstagramEmulator;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User(10, 20);
        User user2 = new User(10, 20);
        User user3 = new User(10, 20);

        user1.Subscribe(user2);
        user1.Subscribe(user3);
        user2.Subscribe(user3);

        user1.NewPostAdded += ShowNotification;
        user2.NewPostAdded += ShowNotification;
        user3.NewPostAdded += ShowNotification;

        user1.AddPost(new Post("Post 1 by user1", DateTime.Now));
        user2.AddPost(new Post("Post 1 by user2", DateTime.Now));
        user3.AddPost(new Post("Post 1 by user3", DateTime.Now));
        user1.AddPost(new Post("Post 2 by user1", DateTime.Now));
        user2.AddPost(new Post("Post 2 by user2", DateTime.Now));
        user3.AddPost(new Post("Post 3 by user3", DateTime.Now));

        Console.ReadLine();
    }

    static void ShowNotification(Post post)
    {
        Console.WriteLine($"New post added: {post.Caption}");
    }
}
