﻿let removeBtn = Array.from(document.getElementsByClassName("img-box-remove"))
let previewImage = document.querySelector(".preview-image")
let imageBox = document.querySelector(".img-box")

function AuthorEdit(id)
{
    fetch(`author/edit/${id}`)
}


function DeleteAlert(controller, id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed)
        {
            fetch(`${controller}/delete/${id}`)
                .then(function(data)
                {
                    console.log(data)
                    if (data.status == 200)
                    {
                        Swal.fire({
                            title: 'Deleted!',
                            text: 'Your file has been deleted.',
                            confirmButtonText: 'succses'
                        }).then((result) =>
                        {
                            if (result.isConfirmed) { location.reload(true)}
                        })
                    }
                })
        }
    })
}

removeBtn.forEach(function (ev) {
    ev.addEventListener("click", function (ev) {
        imageBox.remove(previewImage)
    })
})