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

        /// <summary>
        /// Method to get records whose rating is greater than 3 and product ID is 1 or 4 or 9
        /// </summary>
        /// <param name="productReviews"></param>
        public void SpecifiedRecords(List<ProductReview> productReviews)
        {
            var data = from reviews in productReviews
                       where (reviews.ProductId == 1 || reviews.ProductId == 4 || reviews.ProductId == 9) && reviews.Rating > 3
                       select reviews;

            foreach (var item in data)
            {
                Console.WriteLine("Product ID : " + item.ProductId);
                Console.WriteLine("User ID    : " + item.UserId);
                Console.WriteLine("Rating     : " + item.Rating);
                Console.WriteLine("Review     : " + item.Review);
                Console.WriteLine("Is Like    : " + item.IsLike + "\n");
            }
        }

        /// <summary>
        /// Method to get count of review for each product id
        /// </summary>
        /// <param name="productReviews"></param>
        public void CountOfRecords(List<ProductReview> productReviews)
        {
            var data = productReviews.GroupBy(products => products.ProductId).Select(products => new { productId = products.Key, count = products.Count() });

            foreach (var item in data)
            {
                Console.WriteLine(item.productId + "---" + item.count);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method to retrieve product id and review
        /// </summary>
        /// <param name="ProductReviews"></param>
        public void RetrieveIdAndReview(List<ProductReview> ProductReviews)
        {
            var data = ProductReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review });

            foreach (var list in data)
            {
                Console.WriteLine(list.ProductId + "  ---  " + list.Review);
            }
            Console.WriteLine();
        }
    }
}
