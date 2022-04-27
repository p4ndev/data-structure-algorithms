# Open terminal
BackEnd folder (.Net API Project)

# Create an image (run in CMD/BASH/PS)
docker image build -t cynet-backend:1.0 .

# Create a container
docker run -p 5000:5000 cynet-backend:1.0

# Open Swagger on your browser
http://localhost:5000/swagger/index.html