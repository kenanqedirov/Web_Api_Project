using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            ResultInstagramFollowersDto resultInstagramFollowersDtos = new ResultInstagramFollowersDto();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/__qedirov"),
                Headers =
    {
        { "X-RapidAPI-Key", "38094bde0dmsh77a2d7ef24e3011p1462fejsn3519fe37713c" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.instagramFollowers = values.followers;
                ViewBag.instagramFollowing = values.following;

                /////////////////////////////////////////////////////////////////////
                ///
                var client2 = new HttpClient();
                var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=omarmhaimdat&user_id=96479162"),
                    Headers =
    {
        { "X-RapidAPI-Key", "38094bde0dmsh77a2d7ef24e3011p1462fejsn3519fe37713c" },
        { "X-RapidAPI-Host", "twitter154.p.rapidapi.com" },
    },
                };
                using (var response2 = await client2.SendAsync(request2))
                {
                    response2.EnsureSuccessStatusCode();
                    var body2 = await response2.Content.ReadAsStringAsync();
                    var resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                    ViewBag.twitterFollowers = resultTwitterFollowersDto.follower_count;
                    ViewBag.twitterFollowings = resultTwitterFollowersDto.following_count;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fk%25C9%2599nan-q%25C9%2599dirov-391725223%2F&include_skills=false"),
                Headers =
    {
        { "X-RapidAPI-Key", "38094bde0dmsh77a2d7ef24e3011p1462fejsn3519fe37713c" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
                ViewBag.linkedInFollowers = values3.data.followers_count;
            }
            return View();
        }
    }
}