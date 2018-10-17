
//Add new person to table
$('#addPersonBtn').on('click', function () {
    var person = {
        FirstName: $('#CreateFirstName').val(),
        LastName: $('#CreateLastName').val(),
        PersonNumber: $('#CreateSocialSecurityNumber').val(),
        PersonType: $('#CreatePersonType').val()
    }
    var tableRow = '<tr class="newRow" style="border-top: 1px solid #ccc"><td><p><span data-create-fname="' + person.FirstName + '" class="createFname">' + person.FirstName +
        '</span><span data-create-lname="' + person.LastName + '"class="createLname"> ' + person.LastName +
        '</span></p></td><td><p data-create-pnumber="' + person.PersonNumber + '"class="createPnumber">' + person.PersonNumber +
        '</p></td><td><p data-create-ptype="' + person.PersonType + '"class="createPtype">' + person.PersonType +
        '</p></td><td><button class="saveOnePerson btn btn-success" type="button" style="padding: 5px;">Spara</button></td></tr>';

    setTimeout(function () {
        //Append person to first row in table
        $('#personTable > tbody').prepend(tableRow);
    }, 200)
});

//Save one person click
$(document).on('click', '.saveOnePerson', function () {
    var person = {
        FirstName: $(this).closest('.newRow').find('.createFname').data("create-fname"),
        LastName: $(this).closest('.newRow').find('.createLname').data("create-lname"),
        PersonNumber: $(this).closest('.newRow').find('.createPnumber').data("create-pnumber"),
        PersonType: $(this).closest('.newRow').find('.createPtype').data("create-ptype")
    }
    console.log(person);

    var url = $('#personTable').data('url-one');
    setTimeout(function () {
        PostToSaveAction(person, url);
    }, 200)
});

//Save all persons click
$(document).on('click', '#saveAllNewPersonsBtn', function () {
    //Hidden inputs
    $('.createFname').each(function (i, obj) {
        console.log(i, obj);
    });

    //$.each($('#saveTreatmentsForm').serializeArray(), function (i, kv) {
    //    var name = kv.name.substring(kv.name.indexOf('.') + 1);
    //    editData[name] = $.makeArray(editData[name]);
    //    editData[name].push(kv.value);
    //});

    //var hiddeninput = '<input id="CreateRequest_ListOfPersons_0__FirstName" name="CreateRequest.ListOfPersons[0].FirstName" type="hidden" value="">';
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



