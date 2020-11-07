
let risorse = [];

$('#get-risorse').on('click', () => {
    $.getJSON("http://localhost:51710/api/Risorsa/GetAll").done(function (data) {
        risorse = [];
        for (let r of data) {
            $('#risorse').append(`<p>ID: ${r.id}</p>`);
            // `<p>User: ${r.user}</p>`
            // `<p>Nome: ${r.nome}</p>`
            // `<p>Cognome ${r.cognome}</p>`
            // `<p>FiguraProfessionaleID: ${r.figuraProfessionaleID}</p>`
            // `<p>DescrizioneFiguraProfessionale: ${r.descrizioneFiguraProfessionale}</p>`);;
            $('#risorse').append(`<p>User: ${r.user}</p>`);
            $('#risorse').append(`<p>Nome: ${r.nome}</p>`);
            $('#risorse').append(`<p>Cognome ${r.cognome}</p>`);
            $('#risorse').append(`<p>FiguraProfessionaleID: ${r.figuraProfessionaleID}</p>`);
            $('#risorse').append(`<p>DescrizioneFiguraProfessionale: ${r.descrizioneFiguraProfessionale}</p>`);
            $('#risorse').append(`<br>`);
            $('#risorse').append(`<hr>`);
            risorse.push(r);
        }
        console.log("risorse: ", risorse);
    })
})

$('#get-figureprofessionali').on('click', () => {
    $.getJSON("http://localhost:51710/api/FiguraProfessionale/GetAll").done(function (data) {
        figureprofessionali = [];
        for (let f of data) {
            $("#figure-professionali").append(`<p>ID: ${f.figuraProfessionaleID}</p>`);
            $("#figure-professionali").append(`<p>Descrizione: ${f.descrizione}</p>`);
            $("#figure-professionali").append(`<br><hr>`);
            figureprofessionali.push(f);
        }
        console.log("Figure Professionali: ", figureprofessionali);
    })
})