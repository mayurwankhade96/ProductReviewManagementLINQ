using System;
using System.Collections.Generic;

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

            foreach (var reviewList in productReviews)
            {
                Console.WriteLine("Product ID : " + reviewList.ProductId);
                Console.WriteLine("User ID    : " + reviewList.UserId);
                Console.WriteLine("Rating     : " + reviewList.Rating);
                Console.WriteLine("Review     : " + reviewList.Review);
                Console.WriteLine("Is Like    : " + reviewList.IsLike + "\n");
            }
        }
    }
}
