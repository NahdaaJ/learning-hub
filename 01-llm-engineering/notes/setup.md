# Setup

## Getting started with Ollama
1. Download Ollama from [this website](https://ollama.com/download). 
2. Run the installer once it has downloaded.
3. Run the following command in your terminal - `ollama run [model]`. I used the model `llama3.2`.
4. Now you can chat with the model.

You can pick models here: https://ollama.com/search.

## Getting started with Anaconda
1. Download Anaconda here: https://www.anaconda.com/download/success
2. I then used a very specific set up to my course and its github repo including:
    1. opening the Anaconda Powershel Prompt,
    2. running command `conda env create -f environment.yml` to create the environment using the file the tutor,
    3. running command `conda activate llms` to run the new virtual environment,
    4. using command `jupyter lab` to open a local instance of jupyter.