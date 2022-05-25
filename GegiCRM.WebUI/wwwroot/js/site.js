﻿//fullscreen
function toggleFullScreen() {
    if (!document.fullscreenElement &&    // alternative standard method
        !document.mozFullScreenElement && !document.webkitFullscreenElement && !document.msFullscreenElement) // current working methods
    {
        if (document.documentElement.requestFullscreen) {
            document.documentElement.requestFullscreen();
        } else if (document.documentElement.msRequestFullscreen) {
            document.documentElement.msRequestFullscreen();
        } else if (document.documentElement.mozRequestFullScreen) {
            document.documentElement.mozRequestFullScreen();
        } else if (document.documentElement.webkitRequestFullscreen) {
            document.documentElement.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
        }
    } else {
        if (document.exitFullscreen) {
            document.exitFullscreen();
        } else if (document.msExitFullscreen) {
            document.msExitFullscreen();
        } else if (document.mozCancelFullScreen) {
            document.mozCancelFullScreen();
        } else if (document.webkitExitFullscreen) {
            document.webkitExitFullscreen();
        }
    }
}
$("#fullScreenButton").on("click", function () {
    toggleFullScreen();
});

//search
var searchDataSet = $("#menuUl li");
$("#topNavSearch").on("input", function () {
    var val = $("#topNavSearch").val();
    if (val.length > 1) {
        //console.log("searching: " + val);
        SearchInDataSet(val);
        $("#topNavSearchResults").fadeIn("fast");
    } else {
        $("#topNavSearchResults").hide();
    }

});

$(window).click(function () {
    //Hide the menus if visible
    $("#topNavSearchResults").hide();
});

$('#topNavSearchContainer').click(function (event) {
    event.stopPropagation();
});

$("#topNavSearch").on("focusin", function () {
    $("#topNavSearchResults").fadeIn("fast");
});

function SearchInDataSet(value) {
    $("#topNavSearchResults .list-group").html("");
    var searchResults = [];
    var el;
    for (var i = 0; i < searchDataSet.length; i++) {
        var item = $(searchDataSet[i]);

        var href = item.children("a").attr("href");
        var alt = item.attr("alt");
        var aAlt = item.children("a").attr("alt");
        var text = item[0].innerText;

        var str = [text, href, alt, aAlt];
        str = str.toString().toLowerCase().replace(/,/g, '');;
        value = value.toLowerCase();

        if (str.toLowerCase().indexOf(value) >= 0) {
            el = '<a href="' + href + '" class="list-group-item list-group-item-action">' + text + '</a>';
            searchResults.push(el);
        }
    }
    if (searchResults.length < 1) {
        searchResults = [];
        el = '<a href="javascript:void(0);" class="list-group-item list-group-item-action disabled">"' + value + '" İçin Sonuç Bulunamadı</a>';
        searchResults.push(el);
    }
    var arrayToStr = searchResults.toString().replace(/,/g, '');
    //console.log(arrayToStr);
    $("#topNavSearchResults .list-group").html(arrayToStr);
}

//selectPicker (bootstrap-select)
$(document).on("ready ajaxSuccess", function () {
    $(function () {
        $('.selectpicker').select2(
            {
                language: "tr"
            });


        //$('.selectpicker').selectpicker();
    });

});

//menu active
$(document).ready(function() {

});
