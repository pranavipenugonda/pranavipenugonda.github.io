fetch("./data.json")
				.then((response) => {
					return response.json();
				})
				.then((data) => {
					console.log(data, "data");
					let imagesContainer = document.getElementById("imagesContainer");

					for (let i = 0; i < data.nfts.length; i++) {
						let newCard = document.createElement("div");
						newCard.className = "imageCard";
						newCard.onclick = function () {
							stingifiedData = JSON.stringify(data.nfts[i]);
							localStorage.setItem("objectToPass", stingifiedData);
							window.location.href = `./details.html`;
							// window.location.href = `./details.html?nftInfo=${data.nfts[i]}`;
						};

						let img = document.createElement("img");
						img.className = "galleryImg";
						img.src =
							`https://s7nspfp.mypinata.cloud/ipfs/` + data.nfts[i].image;
						newCard.appendChild(img);

						let div = document.createElement("div");
						div.innerHTML =
							`<p class="flex">
								<strong>` +
							data.nfts[i].name +
							`</strong>
								<strong class="cardNumber"># 1806</strong>
							</p>
							<p><strong>0.354ETH</strong></p>
							<p>Last sale: 0.0085 WETH</p>`;
						newCard.appendChild(div);

						imagesContainer.appendChild(newCard);
					}
				});