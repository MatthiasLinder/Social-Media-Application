using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using The_Social_Media_Application.Resources;

namespace The_Social_Media_Application
{
    public class MainActivity : ListActivity
    {

        public static List<Post> posts;
        public static List<Comment> comments;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            if (posts == null) TestPosts();

            ListAdapter = new PostAdapter(this, posts);

            FindViewById<Button>(Resource.Id.addPost).Click += addPostButton;

        }

        private void addPostButton(object sender, EventArgs e)
        {

            EditText editText = FindViewById<EditText>(Resource.Id.content);
            posts.Add(new Post
            {

                Name = "TestUser",
                Message = editText.Text,
                Likes = 0,
                Date = DateTimeOffset.Now,
                Comments = new List<Comment>()

            });
            editText.Text = "";
            ListAdapter = new PostAdapter(this, posts);

        }

        #region TestPosts
        public void TestPosts()
        {
            posts = new List<Post>();
            comments = new List<Comment>();

            Comment Comment = new Comment
            {
                Name = "Peeter Sipelgas",
                Message = "Tra kui pede sa oled",
                Likes = 2
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Karupoeg",
                Message = "Ei kannata",
                Likes = 228
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Bemmi vend",
                Message = "Tahax autot",
                Likes = 0
            };
            comments.Add(Comment);

            Post post = new Post
            {
                Name = "Test1",
                Message = "See sonum on tekkinud siia ns",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1541056855),
                Comments = comments
            };
            posts.Add(post);

            comments = new List<Comment>();

            Comment = new Comment
            {
                Name = "Test1. 2post",
                Message = "Test",
                Likes = 3
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Test2. 2post",
                Message = "Test",
                Likes = 5
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Test3. 2post",
                Message = "Test",
                Likes = 9
            };
            comments.Add(Comment);

            post = new Post
            {
                Name = "Test2",
                Message = "Testing message",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1500056855),
                Comments = comments
            };
            posts.Add(post);

            comments = new List<Comment>();

            Comment = new Comment
            {
                Name = "Test1. 3post",
                Message = "Test",
                Likes = 10
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Test2. 3post",
                Message = "Test",
                Likes = 20
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Test3. 3post",
                Message = "Test",
                Likes = 30
            };
            comments.Add(Comment);

            post = new Post
            {
                Name = "Test3",
                Message = "Message to test FACEBOOK",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1305056855),
                Comments = comments
            };
            posts.Add(post);

            comments = new List<Comment>();

            Comment = new Comment
            {
                Name = "Test1. 4post",
                Message = "Test",
                Likes = 10
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Test2. 4post",
                Message = "Test",
                Likes = 10
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Test3. 4post",
                Message = "Test",
                Likes = 10
            };
            comments.Add(Comment);

            post = new Post
            {
                Name = "Test4",
                Message = "See sonum on tekkinud siia ns",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1205056005),
                Comments = comments
            };
            posts.Add(post);
        }
        #endregion

    }
}