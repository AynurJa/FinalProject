

var owl = $('#ay .owl-carousel');
owl.owlCarousel({
    items: 4,
    loop: true,
    margin: 10,
    autoplay: true,
    autoplayTimeout: 1000,
    autoplayHoverPause: true
});

//ajax for search 


//$(function () {

//    $('.searchinput').keypress(function (e) {
//        var key = e.which;
//        if (key == 13)  // the enter key code
//        {
//            $('.searchinput').click();
//            return false;
//        }
//    });
//    $(document).on("click", ".iconsearch", function () {
//        var srcbtn = $(".searchinput").val().toLowerCase()
//        var btnval = $(".active").attr("data-id");
//        if (srcbtn) {
//            alert(srcbtn  , btnval)
//            $.ajax({
//                url: "/Ajax/SearchButton",
//                data: { category: srcbtn, keysearch: btnval },
//                type: "GET",
//                success: function (res) {
//                    $("#ay").html(res)
//                }
//            })
//        }
//    })
//})


////ajax for price search

//$(function () {
//    var fromprice;
//    var toprice;
//    $("#fromprice").keyup(function () {
//        fromprice = +$("#fromprice").val()
//    });
//    $("#toprice").keyup(function () {
//        toprice = +$("#toprice").val()
//    });
//    $(".searchprice").keydown(function (e) {


//        if (e.keyCode == 13) {
//            if (fromprice && toprice != NaN && fromprice && toprice != null) {
//                $.ajax({
//                    url: "/Ajax/_SearchPricePartialView",
//                    type: "GET",
//                    data: { fromprice: fromprice, toprice: toprice },
//                    success: function (res) {
//                        $("#ay").html(res)
//                    }
//                })
//            }
//        }
//    });
//});

//ajax for rent

