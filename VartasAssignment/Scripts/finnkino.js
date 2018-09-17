$(document).ready(makeTable());

//Luodaan taulukko finnkinon apista.
function makeTable() {
        
        var tbody = $("#movieTableBody");
        var table = $("#movieTable");
        var d = new Date();
        var day = d.getDay;
        var month = d.getMonth;
        var year = d.getYear;

        //Haetaan Sellon Finnkinon kyseisen päivän ohjelma.
        $.get("https://www.finnkino.fi/xml/Schedule/?area=1038&dt=" + day + "."+ month+"."+ year+".xml",
            "xml",
            function (data, success) {
                //Jos ei toiminut
                if (success !== "success") {
                    alert("Nyt ei oikein onnistunut");
                }

                else {
                    // Haku onnistui. Haetaan halutut tiedot ja luodaan rivit tauluun.
                    var xml = $(data);
                    var show = xml.find("Show");

                    show.each(function () {
                        var $show = $(this);
                        var title = $show.find("Title").text();
                        var genres = $show.find("Genres").text();
                        var rating = $show.find("Rating").text();
                        var start = parseTime($show.find("dttmShowStart").text());
                        var end = parseTime($show.find("dttmShowEnd").text());
                        tbody.append("<tr> <td>" +
                            title +
                            "</td>" +
                            "<td>" +
                            genres +
                            "</td>" +
                            "<td>" +
                            rating +
                            "</td>" +
                            "<td>" +
                            start +
                            "</td>" +
                            "<td>" +
                            end +
                            "</td> </tr>");


                    });
                    //Lisätään nappi ennen taulua, joka piilottaa osan riveistä
                    var button = $("<button type='button' class='button' >Näytä vain komediat</button>").click(showComedy);
                    button.insertBefore(table);
                }
            });

};
//Metodilla muutetaan datetime näytettävään muotoon
function parseTime(time) {
    var first = 11;
    var last = 16;
    var tmpString = time.substring(first, last);
    return tmpString;
}

function showComedy() {
    $("#movieTableBody tr").filter(function() {
        $(this).toggle($(this).text().indexOf("Komedia") > -1);
       
    });
}


