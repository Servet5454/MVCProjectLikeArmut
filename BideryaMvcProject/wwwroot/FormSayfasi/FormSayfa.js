var turkiye_il_ilce = {
    "iller": [
        { "id": 1, "il": "Adana" },
        { "id": 2, "il": "Adıyaman" },
        { "id": 3, "il": "Afyon" },
        // Diğer iller...
    ],
    "ilceler": {
        1: [
            { "id": 101, "ilce": "Seyhan" },
            { "id": 102, "ilce": "Yüreğir" },
            { "id": 103, "ilce": "Çukurova" },
            // Diğer Adana ilçeleri...
        ],
        2: [
            { "id": 201, "ilce": "Merkez" },
            { "id": 202, "ilce": "Gölbaşı" },
            { "id": 203, "ilce": "Kahta" },
            // Diğer Adıyaman ilçeleri...
        ],
        3: [
            { "id": 301, "ilce": "Merkez" },
            { "id": 302, "ilce": "Sandıklı" },
            { "id": 303, "ilce": "Emirdağ" },
            // Diğer Afyon ilçeleri...
        ],
        // Diğer illerin ilçeleri...
    },
};

// İllerin seçeneklerini dropdown listesine ekleyen fonksiyon
function loadIller() {
    var selectIl = document.getElementById("turkiye_illeri");

    for (var i = 0; i < turkiye_il_ilce.iller.length; i++) {
        var option = document.createElement("option");
        option.text = turkiye_il_ilce.iller[i].il;
        option.value = turkiye_il_ilce.iller[i].id;
        selectIl.appendChild(option);
    }
}

// İlçelerin seçeneklerini dropdown listesine ekleyen fonksiyon
function loadIlceler(ilID) {
    var selectIlce = document.getElementById("turkiye_ilceler");
    selectIlce.innerHTML = ""; // Önceki ilçe seçeneklerini temizle

    var ilceler = turkiye_il_ilce.ilceler[ilID];
    for (var i = 0; i < ilceler.length; i++) {
        var option = document.createElement("option");
        option.text = ilceler[i].ilce;
        option.value = ilceler[i].id;
        selectIlce.appendChild(option);
    }
}

// Sayfa yüklendiğinde illeri dropdown listesine yükle
document.addEventListener("DOMContentLoaded", function () {
    loadIller();
});

// İl seçildiğinde ilçeleri dropdown listesine yükle
function showSelectedIl() {
    var selectIl = document.getElementById("turkiye_illeri");
    var selectedIlID = selectIl.value;
    loadIlceler(selectedIlID);
}
