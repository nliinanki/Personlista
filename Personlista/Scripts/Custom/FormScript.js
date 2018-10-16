$(document).ready(function () {
    console.log("js loaded");

    //Detect change in form
    $('#personSearchForm input').on("change", function () {
        var url = $(this).parent('div.wrapper').data('request-url');

        var searchRequest = {
            DisplayNumber: $('input[name="SearchRequest.DisplayNumber"]:checked').val(),
            SearchString: $("#searchString").val()
        }

        callActionAndRefreshData(searchRequest, url);
    });

    //Ajax
    var callActionAndRefreshData = function (request, url) {
        $.ajax({
            type: "POST",
            url: url,
            data: request,
            success: function (data) {
                $('#searchResult').html(data);
            }
        });
    };

})