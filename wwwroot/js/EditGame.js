const form = document.querySelector('form');

const id = document.querySelector('#title').dataset.id;

form.addEventListener('submit', async (e) => {
	e.preventDefault();

	const formData = {
		title: document.querySelector('#title').value.trim(),
		timeSpent: document.querySelector('#timeSpent').value,
		imgUrl: document.querySelector('#imgUrl').value,
		isFinished: document.querySelector('#isFinished').checked,
	};

	const putMethod = {
		method: 'PUT',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify(formData),
	};

	console.log(formData);

	await fetch('/api/gamesapi/editgame/' + id, putMethod)
		.then((response) => response.json())
		.then((data) => data)
		.then((window.location.href = 'http://localhost:5000'))
		.catch((err) => console.error(err));
});
