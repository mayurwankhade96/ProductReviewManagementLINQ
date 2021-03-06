using System;
using System.Collections.Generic;
using System.Data;
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
        public void RetrieveIdAndReview(List<ProductReview> productReviews)
        {
            var data = productReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review });

            foreach (var list in data)
            {
                Console.WriteLine(list.ProductId + "  ---  " + list.Review);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method to get all records other than top five
        /// </summary>
        /// <param name="ProductReviews"></param>
        public void SkipTopFiveRecord(List<ProductReview> productReviews)
        {
            var data = (from reviews in productReviews
                        orderby reviews.Rating descending
                        select reviews).Skip(5);

            foreach (var item in data)
            {
                Console.WriteLine("Product ID : " + item.ProductId);
                Console.WriteLine("User ID    : " + item.UserId);
                Console.WriteLine("Rating     : " + item.Rating);
                Console.WriteLine("Review     : " + item.Review);
                Console.WriteLine("Is Like    : " + item.IsLike + "\n");
            }
        }

        public readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// Method to create data table
        /// </summary>
        /// <param name="productReview"></param>
        /// <returns></returns>
        public DataTable CreateTable(List<ProductReview> productReview)
        {
            var columnOne = new DataColumn("ProductId", typeof(int));
            dataTable.Columns.Add(columnOne);

            var columnTwo = new DataColumn("UserId", typeof(int));
            dataTable.Columns.Add(columnTwo);

            var columnThree = new DataColumn("Rating", typeof(double));
            dataTable.Columns.Add(columnThree);

            var columnFour = new DataColumn("Review");
            dataTable.Columns.Add(columnFour);

            var columnFive = new DataColumn("isLike", typeof(bool));
            dataTable.Columns.Add(columnFive);

            return dataTable;
        }

        /// <summary>
        /// Method to get isLike true from data table
        /// </summary>
        /// <param name="table"></param>
        public void RetrieveIsLikeTrueFromDataTable(DataTable table)
        {
            var data = from reviews in table.AsEnumerable()
                       where (reviews.Field<bool>("isLike") == true)
                       select reviews;

            foreach (var item in data)
            {
                Console.WriteLine("Product ID : " + item.Field<int>("ProductId"));
                Console.WriteLine("User ID    : " + item.Field<int>("UserId"));
                Console.WriteLine("Rating     : " + item.Field<double>("Rating"));
                Console.WriteLine("Review     : " + item.Field<string>("Review"));
                Console.WriteLine("Is Like    : " + item.Field<bool>("IsLike"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method to get average ratings
        /// </summary>
        /// <param name="productReviews"></param>
        public void AverageRatings(List<ProductReview> productReviews)
        {
            var data = productReviews.GroupBy(x => x.ProductId).Select(x => new { id = x.Key, avg = x.Average(y => y.Rating) });

            foreach (var item in data)
            {
                Console.WriteLine(item.id + "  --  " + item.avg);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method to get records with product review message as nice
        /// </summary>
        /// <param name="productReviews"></param>
        public void GetProductsWithNiceReview(List<ProductReview> productReviews)
        {
            var data = (from reviews in productReviews
                        where (reviews.Review.Equals("Nice"))
                        select reviews).ToList();

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
        /// Method to get all records of user id 10
        /// </summary>
        /// <param name="productReviews"></param>
        public void GetRecordOfUSerIdTen(List<ProductReview> productReviews)
        {

            var data = (from reviews in productReviews
                        where (reviews.UserId == 10)
                        orderby reviews.Rating descending
                        select reviews).ToList();

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
