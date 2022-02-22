const form = document.forms[0];

form.addEventListener("submit", async e => {
    e.preventDefault();

    const formData = new FormData(form);

    console.log(formData);

    const response = await fetch("/api/Games", {
        method: "PUT",
        body: formData
    });

    console.log(response.status + " " + response.statusText);
});
