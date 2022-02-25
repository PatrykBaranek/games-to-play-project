const deleteBtns = document.querySelectorAll('.deleteBtn');
const url = 'api/gamesapi/deletegame/';

const deleteMethod = async (id) => {
    await fetch(url + id, {
        method: 'delete',
    })
        .then(window.location.href = "http:localhost:5000")
        .catch(error => console.error(error))
};

deleteBtns.forEach((deleteBtn) =>
    deleteBtn.addEventListener(
        'click',
        async (btn) => await deleteMethod(btn.target.dataset.id)
    )
);
