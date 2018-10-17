
//On add new person btn
$('#addPersonBtn').on('click', function () {
    var person = {
        FirstName: $('#CreateFirstName').val(),
        LastName: $('#CreateLastName').val(),
        PersonNumber: $('#CreateSocialSecurityNumber').val(),
        PersonType: $('#CreatePersonType').val()
    }

    setTimeout(function () {
        //Append person to first row in table
        var tableRow = '<tr style="border-top: 1px solid #ccc"><td><p><span class="createFname" data-fname=' + person.FirstName + '>' + person.FirstName
            + '</span><span class="createLname"> ' + person.LastName +
            '</span></p></td><td><p class="createPnumber">' + person.PersonNumber + '</p></td><td><p class="createPtype">' + person.PersonType +
            '</p></td><td><button class="saveOnePerson btn btn-success" type="button" style="padding: 5px;">Spara</button></td></tr>'

        $('#personTable > tbody').prepend(tableRow);

        var url = $('#personTable').data('url-one');
        PostToSaveAction(person, url);
    }, 200)
});

//On save one person click
$(document).on('click', '.saveOnePerson', function() {

    var person = {
        FirstName: $("#personTable").find('#createFname').data('fname'),
        LastName: $("#personTable").find('#createLname').text(),
        PersonNumber: $("#personTable").find('#createPnumber').text(),
        PersonType: $("#personTable").find('#createPtype').text()
    }
    console.log($("#personTable").find('#createFname'), $("#personTable").find('#createFname').data('fname'));

    var url = $('#personTable').data('url-one');

    setTimeout(function () {
        //PostToSaveAction(person, url);
    }, 200)
});

//Ajax save 
function PostToSaveAction(person, url) {
    var searchRequest = {
        DisplayNumber: $('input[name="SearchRequest.DisplayNumber"]:checked').val(),
        SearchString: $('#searchString').val(),
        PageNumber: $(this).data('page-index')
    }

    var createRequest = {
        SearchRequest: searchRequest,
        CreatedPerson: person,
    }

    $.ajax({
        type: "POST",
        url: url,
        data: createRequest,
        success: function (data) {
            $('#searchResult').html(data);
        }
    });
};