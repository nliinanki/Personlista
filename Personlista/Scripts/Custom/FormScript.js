
//Ajax
function callActionAndRefreshData(request) {
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

//Detect change in form
$('#personSearchForm input').on('change', function () {
    var searchRequest = {
        DisplayNumber: $('input[name="SearchRequest.DisplayNumber"]:checked').val(),
        SearchString: $('#searchString').val()
    }

    callActionAndRefreshData(searchRequest);
});

//Detect click on page number
$('.page-link').on('click', function () {
    var searchRequest = {
        DisplayNumber: $('input[name="SearchRequest.DisplayNumber"]:checked').val(),
        SearchString: $('#searchString').val(),
        PageNumber: $(this).data('page-index')
    }

    callActionAndRefreshData(searchRequest);
});


