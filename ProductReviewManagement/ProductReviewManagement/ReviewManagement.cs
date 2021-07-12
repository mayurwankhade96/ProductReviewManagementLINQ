using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    class ReviewManagement
    {
        /// <summary>
        /// Method to get top three records
        /// </summary>
        /// <param name="productReviews"></param>
        public void TopThreeRecords(List<ProductReview> productReviews)
        {
            var data = (from reviews in productReviews
                        orderby reviews.Rating descending
                        select reviews).Take(3);

            foreach (var item in data)
            {
                Console.WriteLine("Product ID : " + item.ProductId);
                Console.WriteLine("User ID    : " + item.UserId);
                Console.WriteLine("Rating     : " + item.Rating);
                Console.WriteLine("Review     : " + item.Review);
                Console.WriteLine("Is Like    : " + item.IsLike + "\n");
            }
        }
    }
}
