Public Class Language
    Public Shared Selectedlanguage As Integer = Languages.English
    Public Enum Languages
        English
        Greek
        Spanish
        French
        German
        Italian
        Portuguese
        Dutch
        Russian
        ChineseSimplified
        ChineseTraditional
        Japanese
        Korean
        Arabic
        Hebrew
        Turkish
        Polish
        Swedish
        Norwegian
        Danish
        Finnish
        Czech
        Hungarian
        Romanian
        Thai
        Vietnamese
        Hindi
        Indonesian
        Malay
        Ukrainian
    End Enum

    Public Shared LanguagesNames As String(,) = {
    {"English", "English"},
    {"Greek", "Ελληνικά"},
    {"Spanish", "Español"},
    {"French", "Français"},
    {"German", "Deutsch"},
    {"Italian", "Italiano"},
    {"Portuguese", "Português"},
    {"Dutch", "Nederlands"},
    {"Russian", "Русский"},
    {"Chinese (Simplified)", "简体中文"},
    {"Chinese (Traditional)", "繁體中文"},
    {"Japanese", "日本語"},
    {"Korean", "한국어"},
    {"Arabic", "العربية"},
    {"Hebrew", "עברית"},
    {"Turkish", "Türkçe"},
    {"Polish", "Polski"},
    {"Swedish", "Svenska"},
    {"Norwegian", "Norsk"},
    {"Danish", "Dansk"},
    {"Finnish", "Suomi"},
    {"Czech", "Čeština"},
    {"Hungarian", "Magyar"},
    {"Romanian", "Română"},
    {"Thai", "ไทย"},
    {"Vietnamese", "Tiếng Việt"},
    {"Hindi", "हिन्दी"},
    {"Indonesian", "Bahasa Indonesia"},
    {"Malay", "Bahasa Melayu"},
    {"Ukrainian", "Українська"}
}

    Public Shared save_Translations As String() = {
    "Save",               ' English
    "Αποθήκευση",         ' Greek
    "Guardar",            ' Spanish
    "Enregistrer",        ' French
    "Speichern",          ' German
    "Salva",              ' Italian
    "Salvar",             ' Portuguese
    "Opslaan",            ' Dutch
    "Сохранить",          ' Russian
    "保存",                ' ChineseSimplified
    "儲存",                ' ChineseTraditional
    "保存",                ' Japanese
    "저장",                ' Korean
    "حفظ",                ' Arabic
    "שמור",               ' Hebrew
    "Kaydet",             ' Turkish
    "Zapisz",             ' Polish
    "Spara",              ' Swedish
    "Lagre",              ' Norwegian
    "Gem",                ' Danish
    "Tallenna",           ' Finnish
    "Uložit",             ' Czech
    "Mentés",             ' Hungarian
    "Salvează",           ' Romanian
    "บันทึก",              ' Thai
    "Lưu",                ' Vietnamese
    "सहेजें",              ' Hindi
    "Simpan",             ' Indonesian
    "Simpan",             ' Malay
    "Зберегти"            ' Ukrainian
}

    Public Shared back_Translations As String() = {
        "Back",               ' English
        "Πίσω",               ' Greek
        "Atrás",              ' Spanish
        "Retour",             ' French
        "Zurück",             ' German
        "Indietro",           ' Italian
        "Voltar",             ' Portuguese
        "Terug",              ' Dutch
        "Назад",              ' Russian
        "返回",                ' ChineseSimplified
        "返回",                ' ChineseTraditional
        "戻る",               ' Japanese
        "뒤로",               ' Korean
        "رجوع",               ' Arabic
        "חזרה",              ' Hebrew
        "Geri",               ' Turkish
        "Wstecz",             ' Polish
        "Tillbaka",           ' Swedish
        "Tilbake",            ' Norwegian
        "Tilbage",            ' Danish
        "Takaisin",           ' Finnish
        "Zpět",               ' Czech
        "Vissza",             ' Hungarian
        "Înapoi",             ' Romanian
        "ย้อนกลับ",            ' Thai
        "Quay lại",           ' Vietnamese
        "वापस",               ' Hindi
        "Kembali",            ' Indonesian
        "Kembali",            ' Malay
        "Назад"               ' Ukrainian
    }

    Public Shared delete_Translations As String() = {
    "Delete",             ' English
    "Διαγραφή",           ' Greek
    "Eliminar",           ' Spanish
    "Supprimer",          ' French
    "Löschen",            ' German
    "Elimina",            ' Italian
    "Excluir",            ' Portuguese
    "Verwijderen",        ' Dutch
    "Удалить",            ' Russian
    "删除",                ' ChineseSimplified
    "刪除",                ' ChineseTraditional
    "削除",               ' Japanese
    "삭제",               ' Korean
    "حذف",               ' Arabic
    "מחק",               ' Hebrew
    "Sil",                ' Turkish
    "Usuń",               ' Polish
    "Ta bort",            ' Swedish
    "Slett",              ' Norwegian
    "Slet",               ' Danish
    "Poista",             ' Finnish
    "Smazat",             ' Czech
    "Törlés",             ' Hungarian
    "Șterge",             ' Romanian
    "ลบ",                  ' Thai
    "Xóa",                ' Vietnamese
    "हटाएं",              ' Hindi
    "Hapus",              ' Indonesian
    "Padam",              ' Malay
    "Видалити"            ' Ukrainian
}

    Public Shared message1_Translations As String() = {
    "Enter password",                     ' English
    "Εισαγάγετε τον κωδικό πρόσβασης",    ' Greek
    "Introduzca la contraseña",           ' Spanish
    "Entrez le mot de passe",             ' French
    "Passwort eingeben",                  ' German
    "Inserisci la password",              ' Italian
    "Digite a senha",                     ' Portuguese
    "Voer wachtwoord in",                 ' Dutch
    "Введите пароль",                     ' Russian
    "输入密码",                             ' ChineseSimplified
    "輸入密碼",                             ' ChineseTraditional
    "パスワードを入力してください",           ' Japanese
    "비밀번호를 입력하세요",                  ' Korean
    "أدخل كلمة المرور",                    ' Arabic
    "הזן סיסמה",                          ' Hebrew
    "Parolayı girin",                     ' Turkish
    "Wprowadź hasło",                     ' Polish
    "Ange lösenord",                      ' Swedish
    "Skriv inn passord",                  ' Norwegian
    "Indtast adgangskode",                ' Danish
    "Anna salasana",                      ' Finnish
    "Zadejte heslo",                      ' Czech
    "Adja meg a jelszót",                 ' Hungarian
    "Introduceți parola",                 ' Romanian
    "ป้อนรหัสผ่าน",                         ' Thai
    "Nhập mật khẩu",                      ' Vietnamese
    "पासवर्ड दर्ज करें",                   ' Hindi
    "Masukkan kata sandi",                ' Indonesian
    "Masukkan kata laluan",               ' Malay
    "Введіть пароль"                      ' Ukrainian
}

    Public Shared Search_Translation As String() = {
    "Search by patient's name",              ' English
    "Αναζήτηση με το όνομα του ασθενούς",     ' Greek
    "Buscar por el nombre del paciente",      ' Spanish
    "Rechercher par le nom du patient",       ' French
    "Suche nach dem Namen des Patienten",     ' German
    "Cerca per nome del paziente",            ' Italian
    "Pesquisar pelo nome do paciente",        ' Portuguese
    "Zoeken op naam van patiënt",             ' Dutch
    "Поиск по имени пациента",                ' Russian
    "按患者姓名搜索",                            ' ChineseSimplified
    "按病人姓名搜尋",                            ' ChineseTraditional
    "患者の名前で検索",                          ' Japanese
    "환자 이름으로 검색",                        ' Korean
    "البحث حسب اسم المريض",                    ' Arabic
    "חפש לפי שם המטופל",                      ' Hebrew
    "Hasta adını ara",                        ' Turkish
    "Szukaj po imieniu pacjenta",             ' Polish
    "Sök efter patientens namn",              ' Swedish
    "Søk etter pasientens navn",              ' Norwegian
    "Søg efter patientens navn",              ' Danish
    "Hae potilaan nimellä",                   ' Finnish
    "Hledat podle jména pacienta",            ' Czech
    "Keresés a páciens nevére",               ' Hungarian
    "Căutare după numele pacientului",        ' Romanian
    "ค้นหาตามชื่อผู้ป่วย",                      ' Thai
    "Tìm theo tên bệnh nhân",                 ' Vietnamese
    "रोगी के नाम से खोजें",                    ' Hindi
    "Cari berdasarkan nama pasien",           ' Indonesian
    "Cari mengikut nama pesakit",             ' Malay
    "Пошук за ім’ям пацієнта"                 ' Ukrainian
}

    Public Shared Add_Patient_Translation As String() = {
    "Add patient",              ' English
    "Προσθήκη ασθενούς",        ' Greek
    "Agregar paciente",         ' Spanish
    "Ajouter un patient",       ' French
    "Patient hinzufügen",       ' German
    "Aggiungi paziente",        ' Italian
    "Adicionar paciente",       ' Portuguese
    "Patiënt toevoegen",        ' Dutch
    "Добавить пациента",        ' Russian
    "添加病人",                   ' ChineseSimplified
    "新增病人",                   ' ChineseTraditional
    "患者を追加",                 ' Japanese
    "환자 추가",                  ' Korean
    "إضافة مريض",               ' Arabic
    "הוסף מטופל",               ' Hebrew
    "Hasta ekle",               ' Turkish
    "Dodaj pacjenta",           ' Polish
    "Lägg till patient",        ' Swedish
    "Legg til pasient",         ' Norwegian
    "Tilføj patient",           ' Danish
    "Lisää potilas",            ' Finnish
    "Přidat pacienta",          ' Czech
    "Páciens hozzáadása",       ' Hungarian
    "Adaugă pacient",           ' Romanian
    "เพิ่มผู้ป่วย",              ' Thai
    "Thêm bệnh nhân",           ' Vietnamese
    "रोगी जोड़ें",              ' Hindi
    "Tambahkan pasien",         ' Indonesian
    "Tambah pesakit",           ' Malay
    "Додати пацієнта"           ' Ukrainian
}

    Public Shared Input_Req As String() = {
    "Input Required",           ' English
    "Απαιτείται είσοδος",       ' Greek
    "Entrada requerida",        ' Spanish
    "Entrée requise",           ' French
    "Eingabe erforderlich",     ' German
    "Input richiesto",          ' Italian
    "Entrada obrigatória",      ' Portuguese
    "Invoer vereist",           ' Dutch
    "Требуется ввод",           ' Russian
    "需要输入",                   ' ChineseSimplified
    "需要輸入",                   ' ChineseTraditional
    "入力が必要です",              ' Japanese
    "입력이 필요합니다",           ' Korean
    "الإدخال مطلوب",             ' Arabic
    "נדרש קלט",                 ' Hebrew
    "Girdi gerekli",            ' Turkish
    "Wymagane dane",            ' Polish
    "Inmatning krävs",          ' Swedish
    "Inndata kreves",           ' Norwegian
    "Input påkrævet",           ' Danish
    "Syöte vaaditaan",          ' Finnish
    "Vyžadován vstup",          ' Czech
    "Bemenet szükséges",        ' Hungarian
    "Intrare necesară",         ' Romanian
    "ต้องป้อนข้อมูล",             ' Thai
    "Cần nhập",                 ' Vietnamese
    "इनपुट आवश्यक है",           ' Hindi
    "Input diperlukan",         ' Indonesian
    "Input diperlukan",         ' Malay
    "Потрібне введення"         ' Ukrainian
}

    Public Shared Name As String() = {
    "Name",        ' English
    "Όνομα",       ' Greek
    "Nombre",      ' Spanish
    "Nom",         ' French
    "Name",        ' German
    "Nome",        ' Italian
    "Nome",        ' Portuguese
    "Naam",        ' Dutch
    "Имя",         ' Russian
    "姓名",          ' ChineseSimplified
    "姓名",          ' ChineseTraditional
    "名前",         ' Japanese
    "이름",         ' Korean
    "الاسم",       ' Arabic
    "שם",          ' Hebrew
    "Ad",          ' Turkish
    "Imię",        ' Polish
    "Namn",        ' Swedish
    "Navn",        ' Norwegian
    "Navn",        ' Danish
    "Nimi",        ' Finnish
    "Jméno",       ' Czech
    "Név",         ' Hungarian
    "Nume",        ' Romanian
    "ชื่อ",         ' Thai
    "Tên",         ' Vietnamese
    "नाम",         ' Hindi
    "Nama",        ' Indonesian
    "Nama",        ' Malay
    "Ім’я"         ' Ukrainian
}

    Public Shared Surname As String() = {
    "Surname",           ' English
    "Επώνυμο",           ' Greek
    "Apellido",          ' Spanish
    "Nom de famille",    ' French
    "Nachname",          ' German
    "Cognome",           ' Italian
    "Sobrenome",         ' Portuguese
    "Achternaam",        ' Dutch
    "Фамилия",           ' Russian
    "姓",                 ' ChineseSimplified
    "姓",                 ' ChineseTraditional
    "名字",               ' Japanese
    "성",                 ' Korean
    "اللقب",             ' Arabic
    "שם משפחה",          ' Hebrew
    "Soyad",             ' Turkish
    "Nazwisko",          ' Polish
    "Efternamn",         ' Swedish
    "Etternavn",         ' Norwegian
    "Efternavn",         ' Danish
    "Sukunimi",          ' Finnish
    "Příjmení",          ' Czech
    "Vezetéknév",        ' Hungarian
    "Prenume",           ' Romanian
    "นามสกุล",            ' Thai
    "Họ",                ' Vietnamese
    "उपनाम",             ' Hindi
    "Nama belakang",     ' Indonesian
    "Nama keluarga",     ' Malay
    "Прізвище"           ' Ukrainian
}

    Public Shared AMKA As String() = {
    "Social Security Number",                                ' English
    "Αριθμός Μητρώου Κοινωνικής Ασφάλισης (ΑΜΚΑ)",             ' Greek
    "Número de Seguridad Social",                             ' Spanish
    "Numéro de sécurité sociale",                             ' French
    "Sozialversicherungsnummer",                              ' German
    "Numero di previdenza sociale",                           ' Italian
    "Número de Segurança Social",                             ' Portuguese
    "Burgerservicenummer (BSN)",                              ' Dutch
    "Страховой номер (СНИЛС)",                                ' Russian
    "社会保障号码",                                               ' ChineseSimplified
    "社會保障號碼",                                               ' ChineseTraditional
    "マイナンバー",                                             ' Japanese
    "주민등록번호",                                              ' Korean
    "رقم الضمان الاجتماعي",                                   ' Arabic
    "מספר ביטוח לאומי",                                       ' Hebrew
    "Sosyal Güvenlik Numarası",                               ' Turkish
    "Numer ubezpieczenia społecznego",                        ' Polish
    "Personnummer",                                           ' Swedish
    "Fødselsnummer",                                          ' Norwegian
    "CPR-nummer",                                             ' Danish
    "Henkilötunnus",                                          ' Finnish
    "Rodné číslo",                                            ' Czech
    "Társadalombiztosítási szám",                             ' Hungarian
    "Cod numeric personal",                                   ' Romanian
    "หมายเลขประกันสังคม",                                      ' Thai
    "Số an sinh xã hội",                                      ' Vietnamese
    "सामाजिक सुरक्षा संख्या",                                  ' Hindi
    "Nomor Jaminan Sosial",                                   ' Indonesian
    "Nombor Keselamatan Sosial",                              ' Malay
    "Ідентифікаційний номер платника податків"                ' Ukrainian
}

    Public Shared Birth_Date As String() = {
    "Date of Birth",           ' English
    "Ημερομηνία γέννησης",     ' Greek
    "Fecha de nacimiento",     ' Spanish
    "Date de naissance",       ' French
    "Geburtsdatum",            ' German
    "Data di nascita",         ' Italian
    "Data de nascimento",      ' Portuguese
    "Geboortedatum",           ' Dutch
    "Дата рождения",           ' Russian
    "出生日期",                  ' ChineseSimplified
    "出生日期",                  ' ChineseTraditional
    "生年月日",                 ' Japanese
    "생년월일",                 ' Korean
    "تاريخ الميلاد",           ' Arabic
    "תאריך לידה",             ' Hebrew
    "Doğum tarihi",            ' Turkish
    "Data urodzenia",          ' Polish
    "Födelsedatum",            ' Swedish
    "Fødselsdato",             ' Norwegian
    "Fødselsdato",             ' Danish
    "Syntymäaika",             ' Finnish
    "Datum narození",          ' Czech
    "Születési dátum",         ' Hungarian
    "Data nașterii",           ' Romanian
    "วันเกิด",                  ' Thai
    "Ngày sinh",               ' Vietnamese
    "जन्म तिथि",              ' Hindi
    "Tanggal lahir",           ' Indonesian
    "Tarikh lahir",            ' Malay
    "Дата народження"          ' Ukrainian
}

    Public Shared Telephone_Number As String() = {
    "Telephone Number",        ' English
    "Αριθμός τηλεφώνου",        ' Greek
    "Número de teléfono",       ' Spanish
    "Numéro de téléphone",      ' French
    "Telefonnummer",            ' German
    "Numero di telefono",       ' Italian
    "Número de telefone",       ' Portuguese
    "Telefoonnummer",           ' Dutch
    "Номер телефона",           ' Russian
    "电话号码",                   ' ChineseSimplified
    "電話號碼",                   ' ChineseTraditional
    "電話番号",                  ' Japanese
    "전화번호",                  ' Korean
    "رقم الهاتف",               ' Arabic
    "מספר טלפון",              ' Hebrew
    "Telefon numarası",         ' Turkish
    "Numer telefonu",           ' Polish
    "Telefonnummer",            ' Swedish
    "Telefonnummer",            ' Norwegian
    "Telefonnummer",            ' Danish
    "Puhelinnumero",            ' Finnish
    "Telefonní číslo",          ' Czech
    "Telefonszám",              ' Hungarian
    "Număr de telefon",         ' Romanian
    "หมายเลขโทรศัพท์",           ' Thai
    "Số điện thoại",            ' Vietnamese
    "टेलीफोन नंबर",            ' Hindi
    "Nomor telepon",            ' Indonesian
    "Nombor telefon",           ' Malay
    "Номер телефону"            ' Ukrainian
}

    Public Shared Add_Visit As String() = {
    "Add visit",              ' English
    "Προσθήκη επίσκεψης",     ' Greek
    "Agregar visita",         ' Spanish
    "Ajouter une visite",     ' French
    "Besuch hinzufügen",      ' German
    "Aggiungi visita",        ' Italian
    "Adicionar visita",       ' Portuguese
    "Bezoek toevoegen",       ' Dutch
    "Добавить визит",         ' Russian
    "添加访问",                 ' ChineseSimplified
    "新增訪問",                 ' ChineseTraditional
    "訪問を追加",              ' Japanese
    "방문 추가",               ' Korean
    "إضافة زيارة",            ' Arabic
    "הוסף ביקור",             ' Hebrew
    "Ziyaret ekle",           ' Turkish
    "Dodaj wizytę",           ' Polish
    "Lägg till besök",        ' Swedish
    "Legg til besøk",         ' Norwegian
    "Tilføj besøg",           ' Danish
    "Lisää käynti",           ' Finnish
    "Přidat návštěvu",        ' Czech
    "Látogatás hozzáadása",   ' Hungarian
    "Adaugă vizită",          ' Romanian
    "เพิ่มการเข้าชม",         ' Thai
    "Thêm lượt khám",         ' Vietnamese
    "यात्रा जोड़ें",          ' Hindi
    "Tambahkan kunjungan",    ' Indonesian
    "Tambah lawatan",         ' Malay
    "Додати візит"            ' Ukrainian
}

    Public Shared Date_v As String() = {
    "Date",             ' English
    "Ημερομηνία",        ' Greek
    "Fecha",            ' Spanish
    "Date",             ' French
    "Datum",            ' German
    "Data",             ' Italian
    "Data",             ' Portuguese
    "Datum",            ' Dutch
    "Дата",             ' Russian
    "日期",              ' ChineseSimplified
    "日期",              ' ChineseTraditional
    "日付",              ' Japanese
    "날짜",              ' Korean
    "التاريخ",          ' Arabic
    "תאריך",            ' Hebrew
    "Tarih",            ' Turkish
    "Data",             ' Polish
    "Datum",            ' Swedish
    "Dato",             ' Norwegian
    "Dato",             ' Danish
    "Päivämäärä",        ' Finnish
    "Datum",            ' Czech
    "Dátum",            ' Hungarian
    "Dată",             ' Romanian
    "วันที่",             ' Thai
    "Ngày",             ' Vietnamese
    "तारीख",            ' Hindi
    "Tanggal",          ' Indonesian
    "Tarikh",           ' Malay
    "Дата"              ' Ukrainian
}

    Public Shared Diagnosis_Progress As String() = {
    "Diagnosis / Patient progress",                 ' English
    "Διάγνωση / πορεία ασθενούς",                   ' Greek
    "Diagnóstico / evolución del paciente",         ' Spanish
    "Diagnostic / évolution du patient",            ' French
    "Diagnose / Krankheitsverlauf",                 ' German
    "Diagnosi / decorso del paziente",              ' Italian
    "Diagnóstico / evolução do paciente",           ' Portuguese
    "Diagnose / voortgang patiënt",                 ' Dutch
    "Диагноз / течение болезни",                   ' Russian
    "诊断 / 病人病情进展",                            ' ChineseSimplified
    "診斷 / 病人病情進展",                            ' ChineseTraditional
    "診断 / 患者の経過",                              ' Japanese
    "진단 / 환자 경과",                               ' Korean
    "تشخيص / تطور حالة المريض",                      ' Arabic
    "אבחנה / מצב התקדמות המטופל",                  ' Hebrew
    "Tanı / hastanın seyri",                        ' Turkish
    "Diagnoza / przebieg choroby",                  ' Polish
    "Diagnos / patientens utveckling",              ' Swedish
    "Diagnose / pasientens utvikling",              ' Norwegian
    "Diagnose / patientens forløb",                 ' Danish
    "Diagnoosi / potilaan eteneminen",              ' Finnish
    "Diagnóza / vývoj pacienta",                    ' Czech
    "Diagnózis / beteg állapota",                   ' Hungarian
    "Diagnostic / evoluția pacientului",            ' Romanian
    "การวินิจฉัย / ความคืบหน้าของผู้ป่วย",         ' Thai
    "Chẩn đoán / tiến triển của bệnh nhân",        ' Vietnamese
    "निदान / रोगी की प्रगति",                        ' Hindi
    "Diagnosa / perkembangan pasien",               ' Indonesian
    "Diagnosa / perkembangan pesakit",              ' Malay
    "Діагноз / перебіг хвороби"                     ' Ukrainian
}

    Public Shared Medication As String() = {
    "Medication",                         ' English
    "Φαρμακευτική αγωγή",                 ' Greek
    "Medicación",                         ' Spanish
    "Médication",                         ' French
    "Medikation",                         ' German
    "Medicazione",                        ' Italian
    "Medicação",                          ' Portuguese
    "Medicatie",                          ' Dutch
    "Медикаментозное лечение",           ' Russian
    "药物治疗",                            ' ChineseSimplified
    "藥物治療",                            ' ChineseTraditional
    "投薬",                                ' Japanese
    "약물 치료",                            ' Korean
    "علاج دوائي",                         ' Arabic
    "טיפול תרופתי",                       ' Hebrew
    "İlaç tedavisi",                      ' Turkish
    "Leczenie farmakologiczne",           ' Polish
    "Läkemedelsbehandling",               ' Swedish
    "Medikamentell behandling",           ' Norwegian
    "Medicinbehandling",                  ' Danish
    "Lääkitys",                           ' Finnish
    "Léčba léky",                         ' Czech
    "Gyógyszeres kezelés",               ' Hungarian
    "Tratament medicamentos",             ' Romanian
    "การรักษาด้วยยา",                     ' Thai
    "Điều trị bằng thuốc",                ' Vietnamese
    "दवा उपचार",                          ' Hindi
    "Pengobatan",                         ' Indonesian
    "Rawatan ubat",                       ' Malay
    "Медикаментозне лікування"           ' Ukrainian
}

End Class
