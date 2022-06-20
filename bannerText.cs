using System;

namespace BannerText
{
    class Program
    {
        
        private void BuildCarousel()
            {
                StringBuilder strBuildImg = new StringBuilder();
                Banner oBanner = new Banner();
                DataSet dsCarousel = new DataSet();
                dsCarousel = oBanner.getAllCarousels();
                if (dsCarousel.Tables.Count > 0 && dsCarousel.Tables[0].Rows.Count > 0)
                {
                    strBuildImg.Append(" <link rel='stylesheet' type='text/css' href='/includes/js/carousel/jcarousel.basic.css' />");
                    strBuildImg.Append("<script type='text/javascript' src='/includes/js/carousel/jquery.js'></script>");
                    strBuildImg.Append("<script type='text/javascript' src='/includes/js/carousel/jquery.jcarousel.min.js'></script>");
                    strBuildImg.Append("<script type='text/javascript' src='/includes/js/carousel/jcarousel.basic.js'></script>");

                    strBuildImg.Append("<div class='wrapper'>");
                    strBuildImg.Append("<div class='jcarousel-wrapper'>");
                    strBuildImg.Append("<div  class='jcarousel'>");
                    strBuildImg.Append("<ul>");
                    foreach (DataRow dr in dsCarousel.Tables[0].Rows)
                    {
                        string imgPath = "/admin/banners/" + dr["imagename"].ToString();
                        strBuildImg.Append("<li><img src='" + imgPath + "' width='" + dr["width"].ToString() + "' height='" + dr["height"].ToString() + "' alt='" + dr["alttext"] + "'></li>");
                    }
                    strBuildImg.Append("</ul></div>");
                    strBuildImg.Append("<p class='jcarousel-pagination'></p>");
                    strBuildImg.Append("</div></div>");

                    divCarousel.InnerHtml = strBuildImg.ToString();

                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "carouselScript", "<script>fnCarousel();</script>");
                }
            
            }
    }
}
