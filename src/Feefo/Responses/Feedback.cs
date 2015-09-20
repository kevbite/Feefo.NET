using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Feefo.Responses
{
    public enum Rating
    {
        Unknown = 0,
        [EnumMember(Value = "--")]
        Bad = 1,
        [EnumMember(Value = "-")]
        Poor = 2,
        [EnumMember(Value = "+")]
        Good = 4,
        [EnumMember(Value = "++")]
        Excellent = 5,
        [EnumMember(Value = "W")]
        Withdrawn = int.MaxValue
    }

    public class Feedback
    {
        /// <summary>
        /// Integer representing the position of this item of feedback in the returned results. This does not uniquely identify the feedback item; it only indicates its position in the list of returned feedbacks.
        /// </summary>
        [JsonProperty(PropertyName = "COUNT")]
        public int Count { get; set; }

        /// <summary>
        /// This will be the full comment that the customer left about the service they received, the product
        /// they bought, or both.In service mode, this will relate to the service; in product mode, this will relate
        /// to the product; in both mode, this will include both service and product comments, marked with
        /// �Service:� and �Product:�. Includes<br/> tags.
        /// </summary>
        [JsonProperty(PropertyName = "CUSTOMERCOMMENT")]
        public string CustomerComment { get; set; }

        /// <summary>
        /// The date that this feedback was left.
        /// </summary>
        [JsonProperty(PropertyName = "DATE")]
        public string Date { get; set; }

        /// <summary>
        /// The description of the item the customer is leaving feedback on.
        /// </summary>
        [JsonProperty(PropertyName = "DESCRIPTION")]
        public string Description { get; set; }

        /// <summary>
        /// The URL to share this item of feedback on Facebook.
        /// </summary>
        [JsonProperty(PropertyName = "FACEBOOKSHARELINK")]
        public string FacebookShareLink { get; set; }

        /// <summary>
        /// A unique ID for this item of feedback.
        /// </summary>
        [JsonProperty(PropertyName = "FEEDBACKID")]
        public int FeedbackId { get; set; }

        /// <summary>
        /// The date that this feedback was left.
        /// </summary>
        [JsonProperty(PropertyName = "HREVIEWDATE")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// A rating from bad to excellent.
        /// </summary>
        [JsonProperty(PropertyName = "HREVIEWRATING")]
        public Rating HReviewRating { get; set; }

        /// <summary>
        /// The URL of the product page on the supplier's site.
        /// </summary>
        [JsonProperty(PropertyName = "LINK")]
        public string Link { get; set; }

        /// <summary>
        /// The unique product reference for this order item in Feefo. In retail scenarios, this is usually the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "PRODUCTCODE")]
        public object ProductCode { get; set; }

        /// <summary>
        /// The rating that the customer left about their product.
        /// </summary>
        [JsonProperty(PropertyName = "PRODUCTRATING")]
        public string ProductRating { get; set; }

        /// <summary>
        /// The URL to this feedback item on Feefo, for use in a �Read More� link.
        /// </summary>
        [JsonProperty(PropertyName = "READMOREURL")]
        public string ReadmMoreUrl { get; set; }

        /// <summary>
        /// The rating that the customer left about their service.
        /// </summary>
        [JsonProperty(PropertyName = "SERVICERATING")]
        public string ServiceRating { get; set; }

        /// <summary>
        /// A shortened version of the customer comment, ending in an ellipsis (...) for use when displaying
        /// feedback in a summary view.
        /// </summary>
        [JsonProperty(PropertyName = "SHORTCUSTOMERCOMMENT")]
        public string ShortCustomerComment { get; set; }

        /// <summary>
        /// Contains all vendor comments, and all follow-up customer comments.
        /// </summary>
        [JsonProperty(PropertyName = "FURTHERCOMMENTSTHREAD")]
        public FurtherCommentsThread FurtherCommentsThread { get; set; }

        /// <summary>
        /// The latest product review.
        /// </summary>
        [JsonProperty(PropertyName = "PRODUCTLATEST")]
        public string ProductLatest { get; set; }

        /// <summary>
        /// The latest service review.
        /// </summary>
        [JsonProperty(PropertyName = "SERVICELATEST")]
        public string ServiceLatest { get; set; }

        /// <summary>
        /// A shortened version of the vendor's reply, ending in an ellipsis (...) for use when displaying feedback
        /// in a summary view.
        /// </summary>
        [JsonProperty(PropertyName = "SHORTVENDORCOMMENT")]
        public string ShortVendorComment { get; set; }

        /// <summary>
        /// The full vendor reply to the customer's service comment.
        /// </summary>
        [JsonProperty(PropertyName = "VENDORCOMMENT")]
        public string VendorComment { get; set; }
    }
}