$(function () {

    getAnnouncement();


    //Announcement Ekleme

    $("#sendBtn").click(function () {

        var title = $("#titleInput").val();
        var content = $("#contentInput").val();

        if (content == "" | title == "") {
            alert("Content or Title cannot be empty")
        } else {
            $.ajax(
                {
                    type: "Post",
                    url: '/api/app/announcement',
                    data: {
                        title: title,
                        content: content,
                        createdDate: new Date().toJSON()
                    },
                    success: function (data) {
                        alert("Announcement Added")
                        getAnnouncement()
                    }, error(xhr, status, error) {
                        alert(error)
                    }
                }
            );
        }


    })


    //Announcement listeleme
    function getAnnouncement() {
        $.ajax(
            {
                type: "get",
                url: '/api/app/announcement',
                success: function (data) {
                    console.log(data);
                    var strHtml = "";


                    for (var i = 0; i < data.length; i++) {
                        var today = new Date(data[i].createdDate);
                        var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();
                        var time = today.getHours() + ':' + today.getMinutes() + ':' + today.getSeconds();

                        strHtml += "<li  class='list-group-item'> Title => " + data[i].title + "| Content => "
                        strHtml += data[i].content + "| created Date  =>  " + date + " | Time => " + time + " </li>"
                    }

                    $("#announcementList").html(strHtml);
                },
            }
        );

    }

    //Saatlik announcement Ekleme


    setInterval(function () {


        var titles = [
            "New Product Introduction!",
            "Special Discount Opportunity!",
            "Weekend Campaign!",
            "Free Shipping Offer!",
            "Fall Collection is Here!"
        ];

        var contents = [
            "Discover our new product now.",
            "Don't miss the special 20% discount today only!",
            "Our weekend campaigns have started, don't miss the opportunities!",
            "Free shipping on all orders!",
            "The most stylish and trendy pieces for fall are here!"
        ];

        var randomTitleIndex = Math.floor(Math.random() * titles.length);
        var randomContentIndex = Math.floor(Math.random() * contents.length);

        var title = titles[randomTitleIndex];
        var content = contents[randomContentIndex];



        $.ajax(
            {
                type: "Post",
                url: '/api/app/announcement',

                data: {
                    title: title,
                    content: content,
                    createdDate: new Date().toJSON()
                },
                success: function (data) {

                    getAnnouncement()
                }, error(xhr, status, error) {
                    alert(error)
                }
            }
        );

        getAnnouncement();


        //Eski Duyurularýn silinmesi


        $.ajax(
            {
                type: "get",
                url: '/api/app/announcement',
                success: function (data) {

                    var yesterday = new Date();
                    yesterday.setDate(yesterday.getDate() - 1);

                    for (var i = 0; i < data.length; i++) {
                        var announcementDate = new Date(data[i].createdDate);

                        if (yesterday >= announcementDate) {

                            $.ajax(
                                {
                                    type: "DELETE",
                                    url: '/api/app/announcement/' + data[i].id,

                                    success: function (data) {
                                        console.log("silindi");
                                        getAnnouncement()
                                    }, error(xhr, status, error) {
                                        alert(error)
                                    }
                                }
                            );
                        }                     


                    }


                },
            }
        );









    }, 3600000);



});
