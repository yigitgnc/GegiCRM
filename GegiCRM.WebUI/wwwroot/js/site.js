//fullscreen
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
$(document).on("ajaxSuccess", function () {
    InitCustomInputs();
});

$(document).ready(function () {
    InitCustomInputs();
    SetDefaultAvatarImage();
});

//currency input

function InitCustomInputs() {

    $('input .currency').currencyInput();


    $(function () {
        $('.select2').select2(
            {
                language: "tr"
            }
        );

        //init selectize if its not initilized before
        $(".selectize").each(function () {
            try {
                if (this[0] != undefined && this[0].selectize == undefined) {

                    $(this).selectize({
                        create: false,
                        sortField: "text",
                        placeholder: "Seçiniz...",
                        allowEmptyOption: false,
                    });
                }

            } catch (e) {
                console.log(this);
                console.log(e);
            }
        });

        //$('.selectpicker').selectpicker();



    });
}

(function ($) {
    $.fn.currencyInput = function () {
        this.each(function () {
            //var wrapper = $("<div class='currency-input' />");
            //$(this).wrap(wrapper);
            //$(this).before("<span class='currency-symbol'>$</span>");
            $(this).change(function () {
                var min = parseFloat($(this).attr("min"));
                var max = parseFloat($(this).attr("max"));
                var value = this.valueAsNumber;
                if (value < min)
                    value = min;
                else if (value > max)
                    value = max;
                $(this).val(value.toFixed(2));
            });
        });
    };
})(jQuery);

function SetDefaultAvatarImage() {
    var avatars = $(".profilePicture");

    for (var i = 0; i < avatars.length; i++) {

        var image = $(avatars[i]).attr("src");
        if (!IsImageOk(image)) {
            //console.log("error var");
            $(avatars[i]).attr("src", "/assets/img/avatars/default.webp");
        }

    }



}


function IsImageOk(img) {
    // During the onload event, IE correctly identifies any images that
    // weren’t downloaded as not complete. Others should too. Gecko-based
    // browsers act like NS4 in that they report this incorrectly.
    if (!img.complete) {
        return false;
    }

    // However, they do have two very useful properties: naturalWidth and
    // naturalHeight. These give the true size of the image. If it failed
    // to load, either of these should be zero.
    if (img.naturalWidth === 0) {
        return false;
    }

    // No other way of checking: assume it’s ok.
    return true;
}

function resizeIframe(obj) {
    obj.style.height = obj.contentWindow.document.documentElement.scrollHeight + 'px';
}
