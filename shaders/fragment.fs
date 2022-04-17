#version 450

in vec2 texCoord;

uniform sampler2D txtr;
uniform vec4 vertexColor;

out vec4 fragColor;

void main() {
    fragColor = vertexColor + texture(txtr, texCoord);
}