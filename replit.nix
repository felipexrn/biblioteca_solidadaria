{ pkgs }: {
	deps = [
		pkgs.mono5
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}