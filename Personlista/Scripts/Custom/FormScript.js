
//Detect change in form
$('#personSearchForm .filterInput').on('change', function () {
    console.log("personSearchForm");
    var searchRequest = {
        DisplayNumber: $('input[name="SearchRequest.DisplayNumber"]:checked').val(),
        SearchString: $('#searchString').val()
    }

    setTimeout(function () {
        CallActionAndRefreshData(searchRequest);
    }, 200)
});



//Ajax filter
function CallActionAndRefreshData(request) {
    var url = $('#personSearchForm').attr('action');

        $.ajax({
            type: "POST",
            url: url,
            data: request,
            success: function (data) {
                $('#searchResult').html(data);
            }
        });
};
