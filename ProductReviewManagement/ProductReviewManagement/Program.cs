using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Welcome to Product Review Management using LINQ**" + "\n");

            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() {ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 2, UserId = 2, Rating = 5, Review= "Good", IsLike = true},
                new ProductReview() {ProductId = 3, UserId = 3, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 4, UserId = 4, Rating = 3, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 5, UserId = 5, Rating = 2, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 6, UserId = 6, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 7, UserId = 7, Rating = 3.5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 8, UserId = 8, Rating = 2.5, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 9, UserId = 9, Rating = 5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 10, UserId = 10, Rating = 3.6, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 11, UserId = 11, Rating = 4.5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 12, UserId = 12, Rating = 2.8 , Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 13, UserId = 1, Rating = 1.8, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 14, UserId = 5, Rating = 1, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 15, UserId = 10, Rating = 4.5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 16, UserId = 9, Rating = 2, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 17, UserId = 12, Rating = 4.9, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 18, UserId = 8, Rating = 3.9, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 19, UserId = 7, Rating = 1.4, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 20, UserId = 3, Rating = 4.1, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 21, UserId = 4, Rating = 3.1, Review = "Bad", IsLike = false},
                new ProductReview() {ProductId = 22, UserId = 9, Rating = 4.1, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 23, UserId = 1, Rating = 5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 24, UserId = 5, Rating = 4.3, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 25, UserId = 6, Rating = 1, Review = "Bad", IsLike = false},
            };
            Console.WriteLine("Top three records are as following : " + "\n");
            ReviewManagement management = new ReviewManagement();
            management.TopThreeRecords(productReviews);

            Console.WriteLine("Products whose rating is greater than 3 and product id is 1 or 4 or 9 are as following : " + "\n");
            management.SpecifiedRecords(productReviews);

            Console.WriteLine("Count of review present for each product id : " + "\n");
            management.CountOfRecords(productReviews);

            Console.WriteLine("Product id and reviews are as following : " + "\n");
            Console.WriteLine("ID  |   Review");
            management.RetrieveIdAndReview(productReviews);

            Console.WriteLine("Other than top five records are as follows : " + "\n");
            management.SkipTopFiveRecord(productReviews);

            Console.WriteLine("Product id and reviews are as following : " + "\n");
            Console.WriteLine("ID  |   Review");
            management.RetrieveIdAndReview(productReviews);

            DataTable data = management.CreateTable(productReviews);

            foreach (var table in productReviews)
            {
                data.Rows.Add(table.ProductId, table.UserId, table.Rating, table.Review, table.IsLike);
            }
        }
    }
}
